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
    public class EvaluacionRepository : IEvaluacionRepository
    {
        private readonly BlazorCrudContext _context;

        public EvaluacionRepository(BlazorCrudContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Evaluacion>> GetEvaluaciones()
        {
            var evaluaciones = await _context.Evaluacion.ToListAsync();
            Log.Information("All the existing items have been retrieved successfully");
            return evaluaciones;
        }

        public async Task<IEnumerable<Evaluacion>> GetEvaluacionesPorAlumno(int alumnoId)
        {
            if(alumnoId != 0)
            {
                var evaluaciones = await _context.Evaluacion.Where(n => n.AlumnoId == alumnoId).ToListAsync();
                Log.Information("All the existing items have been retrieved successfully");
                return evaluaciones;
            }
            else
            {
                return null;
            }
        }

        public async Task<Evaluacion> GetEvaluacion(int id)
        {
            var evaluacion = await _context.Evaluacion.FirstOrDefaultAsync(n => n.Id == id);

            if (evaluacion != null)
            {
                Log.Information("The item with id: '{id}' has been retrieved successfully", id);
                return evaluacion;
            }
            else
            {
                Log.Error("The item with id: '{id}' has not been found in the database", id);
                return new Evaluacion();
            }

        }


        public async Task<Evaluacion> CreateEvaluacion(Evaluacion evaluacion)
        {
            _context.Add(evaluacion);
            _context.SaveChanges();

            Log.Information("A new item has been created successfully", evaluacion.Id);

            return evaluacion;
        }

        public async Task<bool> DeleteEvaluacion(int id)
        {
            var evaluacion = _context.Evaluacion.FirstOrDefault(n => n.Id == id);

            if (evaluacion != null)
            {
                _context.Remove(evaluacion);
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

        public async Task<bool> EditEvaluacion(Evaluacion evaluacion)
        {
            var editedEvaluacion = _context.Evaluacion.FirstOrDefault(n => n.Id == evaluacion.Id);

            if (editedEvaluacion != null)
            {
                editedEvaluacion.AlumnoId = evaluacion.AlumnoId;
                editedEvaluacion.AsignaturaId = evaluacion.AsignaturaId;
                editedEvaluacion.Calificacion = evaluacion.Calificacion;
                editedEvaluacion.Comentario = evaluacion.Comentario;
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
