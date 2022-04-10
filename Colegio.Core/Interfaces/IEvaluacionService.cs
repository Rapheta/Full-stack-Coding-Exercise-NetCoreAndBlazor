using Colegio.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Core.Interfaces
{
    public interface IEvaluacionService
    {
        Task<IEnumerable<Evaluacion>> GetEvaluaciones();
        Task<IEnumerable<Evaluacion>> GetEvaluacionesPorAlumno(int alumnoId);
        Task<Evaluacion> GetEvaluacion(int id);
        Task<Evaluacion> CreateEvaluacion(Evaluacion evaluacion);
        Task<bool> DeleteEvaluacion(int id);
        Task<bool> EditEvaluacion(Evaluacion evaluacion);
    }
}
