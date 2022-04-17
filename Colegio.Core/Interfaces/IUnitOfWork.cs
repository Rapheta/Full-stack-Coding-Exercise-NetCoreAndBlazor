using System;

namespace Colegio.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IAlumnosRepository AlumnosRepository { get; }
        IAsignaturasRepository AsignaturasRepository { get; }
        IProfesoresRepository ProfesoresRepository { get; }
        IEvaluacionRepository EvaluacionRepository { get; }
    }
}
