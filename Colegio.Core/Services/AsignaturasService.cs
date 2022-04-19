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
    public class AsignaturasService : IAsignaturasService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDistributedCache _distributedCache;
        public AsignaturasService(IUnitOfWork unitOfWork, IDistributedCache distributedCache)
        {
            _unitOfWork = unitOfWork;
            _distributedCache = distributedCache;
        }

        public async Task<IEnumerable<Asignatura>> GetAsignaturas()
        {
            var cacheKey = "listadoAsignaturas";
            string serializedListadoAsignaturas;
            var listadoAsignaturas = new List<Asignatura>();
            var redisListadoAsignaturas = await _distributedCache.GetAsync(cacheKey);

            if (redisListadoAsignaturas != null)
            {
                serializedListadoAsignaturas = Encoding.UTF8.GetString(redisListadoAsignaturas);
                listadoAsignaturas = JsonConvert.DeserializeObject<List<Asignatura>>(serializedListadoAsignaturas);
            }
            else
            {
                listadoAsignaturas = (List<Asignatura>)await _unitOfWork.AsignaturasRepository.GetAsignaturas();
                serializedListadoAsignaturas = JsonConvert.SerializeObject(listadoAsignaturas);
                redisListadoAsignaturas = Encoding.UTF8.GetBytes(serializedListadoAsignaturas);

                var options = new DistributedCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromMinutes(2));

                await _distributedCache.SetAsync(cacheKey, redisListadoAsignaturas, options);
            }

            return listadoAsignaturas;
        }

        public async Task<Asignatura> GetAsignatura(int id)
        {
            return await _unitOfWork.AsignaturasRepository.GetAsignatura(id);
        }

        public async Task<Asignatura> CreateAsignatura(Asignatura asignatura)
        {
            return await _unitOfWork.AsignaturasRepository.CreateAsignatura(asignatura);
        }

        public async Task<bool> DeleteAsignatura(int id)
        {
            return await _unitOfWork.AsignaturasRepository.DeleteAsignatura(id);
        }

        public async Task<bool> EditAsignatura(Asignatura asignatura)
        {
            return await _unitOfWork.AsignaturasRepository.EditAsignatura(asignatura);
        }
    }
}
