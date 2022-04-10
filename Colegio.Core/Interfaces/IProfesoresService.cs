using Colegio.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Core.Interfaces
{
    public interface IProfesoresService
    {
        Task<IEnumerable<Profesor>> GetProfesores();
        Task<Profesor> GetProfesor(int id);
        Task<Profesor> CreateProfesor(Profesor profesor);
        Task<bool> DeleteProfesor(int id);
        Task<bool> EditProfesor(Profesor profesor);
    }
}
