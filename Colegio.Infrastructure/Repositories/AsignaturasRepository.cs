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
    public class AsignaturasRepository : IAsignaturasRepository
    {
        private readonly BlazorCrudContext _context;

        public AsignaturasRepository(BlazorCrudContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Asignatura>> GetAsignaturas()
        {
            var asignaturas = await _context.Asignatura.ToListAsync();
            Log.Information("All the existing items have been retrieved successfully");
            return asignaturas;
        }

        public async Task<Asignatura> GetAsignatura(int id)
        {
            var asignatura = await _context.Asignatura.FirstOrDefaultAsync(n => n.Id == id);

            if (asignatura != null)
            {
                Log.Information("The item with id: '{id}' has been retrieved successfully", id);
                return asignatura;
            }
            else
            {
                Log.Error("The item with id: '{id}' has not been found in the database", id);
                return new Asignatura();
            }

        }


        public async Task<Asignatura> CreateAsignatura(Asignatura asignatura)
        {
            _context.Add(asignatura);
            _context.SaveChanges();

            Log.Information("A new item has been created successfully", asignatura.Id);

            return asignatura;
        }

        public async Task<bool> DeleteAsignatura(int id)
        {
            var asignatura = _context.Asignatura.FirstOrDefault(n => n.Id == id);

            if (asignatura != null)
            {
                _context.Remove(asignatura);
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

        public async Task<bool> EditAsignatura(Asignatura asignatura)
        {
            var editedAsignatura = _context.Asignatura.FirstOrDefault(n => n.Id == asignatura.Id);

            if (editedAsignatura != null)
            {
                editedAsignatura.Nombre = asignatura.Nombre;
                editedAsignatura.Curso = asignatura.Curso;
                editedAsignatura.ProfesorId = asignatura.ProfesorId;
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
