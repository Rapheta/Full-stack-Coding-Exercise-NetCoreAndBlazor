using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Core.Services
{
    public class EvaluacionService : IEvaluacionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EvaluacionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Evaluacion>> GetEvaluaciones()
        {
            return await _unitOfWork.EvaluacionRepository.GetEvaluaciones();
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
