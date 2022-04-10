using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Core.Services
{
    public class AsignaturasService : IAsignaturasService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AsignaturasService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Asignatura>> GetAsignaturas()
        {
            return await _unitOfWork.AsignaturasRepository.GetAsignaturas();
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
