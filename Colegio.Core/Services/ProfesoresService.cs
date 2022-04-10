using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Core.Services
{
    public class ProfesoresService : IProfesoresService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProfesoresService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Profesor>> GetProfesores()
        {
            return await _unitOfWork.ProfesoresRepository.GetProfesores();
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
