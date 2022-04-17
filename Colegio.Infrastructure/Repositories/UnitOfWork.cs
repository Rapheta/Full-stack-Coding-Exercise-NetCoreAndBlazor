using Colegio.Core.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Colegio.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IAlumnosRepository _alumnosRepository;
        private readonly IProfesoresRepository _profesoresRepository;
        private readonly IAsignaturasRepository _asignaturasRepository;
        private readonly IEvaluacionRepository _evaluacionRepository;
        private readonly IConfiguration _configuration;

        public UnitOfWork(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IAlumnosRepository AlumnosRepository => _alumnosRepository ?? new AlumnosRepository(_configuration);
        public IProfesoresRepository ProfesoresRepository => _profesoresRepository ?? new ProfesoresRepository(_configuration);
        public IAsignaturasRepository AsignaturasRepository => _asignaturasRepository ?? new AsignaturasRepository(_configuration);
        public IEvaluacionRepository EvaluacionRepository => _evaluacionRepository ?? new EvaluacionRepository(_configuration);
    }
}
