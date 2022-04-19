using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Core.Services
{
    public class EvaluacionService : IEvaluacionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDistributedCache _distributedCache;
        public EvaluacionService(IUnitOfWork unitOfWork, IDistributedCache distributedCache)
        {
            _unitOfWork = unitOfWork;
            _distributedCache = distributedCache;
        }

        public async Task<IEnumerable<Evaluacion>> GetEvaluaciones()
        {
            var cacheKey = "listadoEvaluaciones";
            string serializedListadoEvaluaciones;
            var listadoEvaluaciones = new List<Evaluacion>();
            var redisListadoEvaluaciones = await _distributedCache.GetAsync(cacheKey);

            if (redisListadoEvaluaciones != null)
            {
                serializedListadoEvaluaciones = Encoding.UTF8.GetString(redisListadoEvaluaciones);
                listadoEvaluaciones = JsonConvert.DeserializeObject<List<Evaluacion>>(serializedListadoEvaluaciones);
            }
            else
            {
                listadoEvaluaciones = (List<Evaluacion>)await _unitOfWork.EvaluacionRepository.GetEvaluaciones();
                serializedListadoEvaluaciones = JsonConvert.SerializeObject(listadoEvaluaciones);
                redisListadoEvaluaciones = Encoding.UTF8.GetBytes(serializedListadoEvaluaciones);

                var options = new DistributedCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromMinutes(2));

                await _distributedCache.SetAsync(cacheKey, redisListadoEvaluaciones, options);
            }

            return listadoEvaluaciones;
        }

        public async Task<IEnumerable<Evaluacion>> GetEvaluacionesPorAlumno(int alumnoId)
        {
            return await _unitOfWork.EvaluacionRepository.GetEvaluacionesPorAlumno(alumnoId);
        }

        public async Task<Evaluacion> GetEvaluacion(int id)
        {
            return await _unitOfWork.EvaluacionRepository.GetEvaluacion(id);
        }

        public async Task<Evaluacion> CreateEvaluacion(Evaluacion evaluacion)
        {
            return await _unitOfWork.EvaluacionRepository.CreateEvaluacion(evaluacion);
        }

        public async Task<bool> DeleteEvaluacion(int id)
        {
            return await _unitOfWork.EvaluacionRepository.DeleteEvaluacion(id);
        }

        public async Task<bool> EditEvaluacion(Evaluacion evaluacion)
        {
            return await _unitOfWork.EvaluacionRepository.EditEvaluacion(evaluacion);
        }
    }
}
