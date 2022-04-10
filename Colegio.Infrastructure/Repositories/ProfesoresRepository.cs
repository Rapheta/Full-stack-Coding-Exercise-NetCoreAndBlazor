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
    public class ProfesoresRepository : IProfesoresRepository
    {
        private readonly BlazorCrudContext _context;

        public ProfesoresRepository(BlazorCrudContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Profesor>> GetProfesores()
        {
            var profesores = await _context.Profesor.ToListAsync();
            Log.Information("All the existing items have been retrieved successfully");
            return profesores;
        }

        public async Task<Profesor> GetProfesor(int id)
        {
            var profesor = await _context.Profesor.FirstOrDefaultAsync(n => n.Id == id);

            if (profesor != null)
            {
                Log.Information("The item with id: '{id}' has been retrieved successfully", id);
                return profesor;
            }
            else
            {
                Log.Error("The item with id: '{id}' has not been found in the database", id);
                return new Profesor();
            }

        }


        public async Task<Profesor> CreateProfesor(Profesor profesor)
        {
            _context.Add(profesor);
            _context.SaveChanges();

            Log.Information("A new item has been created successfully", profesor.Id);

            return profesor;
        }

        public async Task<bool> DeleteProfesor(int id)
        {
            var profesor = _context.Profesor.FirstOrDefault(n => n.Id == id);

            if (profesor != null)
            {
                _context.Remove(profesor);
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

        public async Task<bool> EditProfesor(Profesor profesor)
        {
            var editedProfesor = _context.Profesor.FirstOrDefault(n => n.Id == profesor.Id);

            if (editedProfesor != null)
            {
                editedProfesor.Nombre = profesor.Nombre;
                editedProfesor.Apellidos = profesor.Apellidos;
                editedProfesor.Area = profesor.Area;
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
