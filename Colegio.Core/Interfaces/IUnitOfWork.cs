using System;
using System.Threading.Tasks;

namespace Colegio.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAlumnosRepository AlumnosRepository { get; }
        IAsignaturasRepository AsignaturasRepository { get; }
        IProfesoresRepository ProfesoresRepository { get; }
        IEvaluacionRepository EvaluacionRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
