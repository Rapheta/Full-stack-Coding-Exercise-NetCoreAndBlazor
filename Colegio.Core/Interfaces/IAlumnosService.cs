using Colegio.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Core.Interfaces
{
    public interface IAlumnosService
    {
        Task<IEnumerable<Alumno>> GetAlumnos();
        Task<Alumno> GetAlumno(int id);
        Task<Alumno> CreateAlumno(Alumno alumno);
        Task<bool> DeleteAlumno(int id);
        Task<bool> EditAlumno(Alumno alumno);
    }
}
