using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Core.Services
{
    public class AlumnosService : IAlumnosService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AlumnosService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Alumno>> GetAlumnos()
        {
            return await _unitOfWork.AlumnosRepository.GetAlumnos();
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
