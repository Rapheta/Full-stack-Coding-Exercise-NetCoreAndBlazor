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
    public class ProfesoresService : IProfesoresService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDistributedCache _distributedCache;
        public ProfesoresService(IUnitOfWork unitOfWork, IDistributedCache distributedCache)
        {
            _unitOfWork = unitOfWork;
            _distributedCache = distributedCache;
        }

        public async Task<IEnumerable<Profesor>> GetProfesores()
        {
            var cacheKey = "listadoProfesores";
            string serializedListadoProfesores;
            var listadoProfesores = new List<Profesor>();
            var redisListadoProfesores = await _distributedCache.GetAsync(cacheKey);

            if (redisListadoProfesores != null)
            {
                serializedListadoProfesores = Encoding.UTF8.GetString(redisListadoProfesores);
                listadoProfesores = JsonConvert.DeserializeObject<List<Profesor>>(serializedListadoProfesores);
            }
            else
            {
                listadoProfesores = (List<Profesor>)await _unitOfWork.ProfesoresRepository.GetProfesores();
                serializedListadoProfesores = JsonConvert.SerializeObject(listadoProfesores);
                redisListadoProfesores = Encoding.UTF8.GetBytes(serializedListadoProfesores);

                var options = new DistributedCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromMinutes(2));

                await _distributedCache.SetAsync(cacheKey, redisListadoProfesores, options);
            }

            return listadoProfesores;
        }

        public async Task<Profesor> GetProfesor(int id)
        {
            return await _unitOfWork.ProfesoresRepository.GetProfesor(id);
        }

        public async Task<Profesor> CreateProfesor(Profesor profesor)
        {
            return await _unitOfWork.ProfesoresRepository.CreateProfesor(profesor);
        }

        public async Task<bool> DeleteProfesor(int id)
        {
            return await _unitOfWork.ProfesoresRepository.DeleteProfesor(id);
        }

        public async Task<bool> EditProfesor(Profesor profesor)
        {
            return await _unitOfWork.ProfesoresRepository.EditProfesor(profesor);
        }
    }
}
