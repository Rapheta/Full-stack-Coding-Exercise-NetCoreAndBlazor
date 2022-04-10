using Colegio.Core.Interfaces;
using Colegio.Infrastructure.Data;
using System.Threading.Tasks;

namespace Colegio.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlazorCrudContext _context;
        private readonly IAlumnosRepository _alumnosRepository;
        private readonly IProfesoresRepository _profesoresRepository;
        private readonly IAsignaturasRepository _asignaturasRepository;
        private readonly IEvaluacionRepository _evaluacionRepository;

        public UnitOfWork(BlazorCrudContext context)
        {
            _context = context;
        }

        public IAlumnosRepository AlumnosRepository => _alumnosRepository ?? new AlumnosRepository(_context);
        public IProfesoresRepository ProfesoresRepository => _profesoresRepository ?? new ProfesoresRepository(_context);
        public IAsignaturasRepository AsignaturasRepository => _asignaturasRepository ?? new AsignaturasRepository(_context);
        public IEvaluacionRepository EvaluacionRepository => _evaluacionRepository ?? new EvaluacionRepository(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
