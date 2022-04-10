using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using Colegio.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colegio.Infrastructure.Repositories
{
    public class AlumnosRepository : IAlumnosRepository
    {
        private readonly BlazorCrudContext _context;

        public AlumnosRepository(BlazorCrudContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Alumno>> GetAlumnos()
        {
            var alumnos = await _context.Alumno.ToListAsync();
            Log.Information("All the existing items have been retrieved successfully");
            return alumnos;
        }

        public async Task<Alumno> GetAlumno(int id)
        {
            var alumno = await _context.Alumno.FirstOrDefaultAsync(n => n.Id == id);

            if(alumno != null)
            {
                Log.Information("The item with id: '{id}' has been retrieved successfully", id);
                return alumno;
            }
            else
            {
                Log.Error("The item with id: '{id}' has not been found in the database", id);
                return new Alumno();
            }
            
        }


        public async Task<Alumno> CreateAlumno(Alumno alumno)
        {
            _context.Add(alumno);
            _context.SaveChanges();

            Log.Information("A new item has been created successfully", alumno.Id);

            return alumno;
        }

        public async Task<bool> DeleteAlumno(int id)
        {
            var alumno = _context.Alumno.FirstOrDefault(n => n.Id == id);

            if (alumno != null)
            {
                _context.Remove(alumno);
                _context.SaveChanges();

                Log.Information("The item with id: '{id}' has been deleted successfully", id);
                return true;
            }
            else
            {
                Log.Error("You attempted to delete a non existing item");
                return false;
            }
        }

        public async Task<bool> EditAlumno(Alumno alumno)
        {
            var editedAlumno = _context.Alumno.FirstOrDefault(n => n.Id == alumno.Id);

            if (editedAlumno != null)
            {
                editedAlumno.Nombre = alumno.Nombre;
                editedAlumno.Apellidos = alumno.Apellidos;
                editedAlumno.Curso = alumno.Curso;
                //+ parameters
                _context.SaveChanges();

                Log.Information("The item has been updated successfully");
                return true;
            }
            else
            {
                Log.Error("You attempted to update a non existing item");
                return false;
            }
        }
    }
}
