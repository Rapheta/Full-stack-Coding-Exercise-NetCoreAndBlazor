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
    public class AlumnosService : IAlumnosService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDistributedCache _distributedCache;
        public AlumnosService(IUnitOfWork unitOfWork, IDistributedCache distributedCache)
        {
            _unitOfWork = unitOfWork;
            _distributedCache = distributedCache;
        }

        public async Task<IEnumerable<Alumno>> GetAlumnos()
        {
            var cacheKey = "listadoAlumnos";
            string serializedListadoAlumnos;
            var listadoAlumnos = new List<Alumno>();
            var redisListadoAlumnos = await _distributedCache.GetAsync(cacheKey);

            if (redisListadoAlumnos != null)
            {
                serializedListadoAlumnos = Encoding.UTF8.GetString(redisListadoAlumnos);
                listadoAlumnos = JsonConvert.DeserializeObject<List<Alumno>>(serializedListadoAlumnos);
            }
            else
            {
                listadoAlumnos = (List<Alumno>)await _unitOfWork.AlumnosRepository.GetAlumnos();
                serializedListadoAlumnos = JsonConvert.SerializeObject(listadoAlumnos);
                redisListadoAlumnos = Encoding.UTF8.GetBytes(serializedListadoAlumnos);

                var options = new DistributedCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromMinutes(2));

                await _distributedCache.SetAsync(cacheKey, redisListadoAlumnos, options);
            }

            return listadoAlumnos;
        }

        public async Task<Alumno> GetAlumno(int id)
        {
            return await _unitOfWork.AlumnosRepository.GetAlumno(id);
        }

        public async Task<Alumno> CreateAlumno(Alumno alumno)
        {
            return await _unitOfWork.AlumnosRepository.CreateAlumno(alumno);
        }

        public async Task<bool> DeleteAlumno(int id)
        {
            return await _unitOfWork.AlumnosRepository.DeleteAlumno(id);
        }

        public async Task<bool> EditAlumno(Alumno alumno)
        {
            return await _unitOfWork.AlumnosRepository.EditAlumno(alumno);
        }
    }
}
