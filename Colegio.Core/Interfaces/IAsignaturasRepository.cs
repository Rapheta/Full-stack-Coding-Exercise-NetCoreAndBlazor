using Colegio.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Core.Interfaces
{
    public interface IAsignaturasRepository
    {
        Task<IEnumerable<Asignatura>> GetAsignaturas();
        Task<Asignatura> GetAsignatura(int id);
        Task<Asignatura> CreateAsignatura(Asignatura asignatura);
        Task<bool> DeleteAsignatura(int id);
        Task<bool> EditAsignatura(Asignatura asignatura);
    }
}
