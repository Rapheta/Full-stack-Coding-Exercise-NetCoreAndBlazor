using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colegio.Infrastructure.Repositories
{
    public class EvaluacionRepository : IEvaluacionRepository
    {
        private readonly IConfiguration _configuration;
        public EvaluacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Evaluacion>> GetEvaluaciones()
        {
            var queryEvaluaciones = "SELECT * FROM evaluacion";
            var evaluaciones = new List<Evaluacion>();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                evaluaciones = (List<Evaluacion>)await connection.QueryAsync<Evaluacion>(queryEvaluaciones).ConfigureAwait(false);
            }

            Log.Information("All the existing items have been retrieved successfully");
            return evaluaciones;
        }

        public async Task<IEnumerable<Evaluacion>> GetEvaluacionesPorAlumno(int alumnoId)
        {
            var queryEvaluacion = "SELECT * FROM evaluacion WHERE alumnoId = @alumnoId";
            var evaluaciones = new List<Evaluacion>();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                evaluaciones = (List<Evaluacion>)await connection.QueryAsync<Evaluacion>(queryEvaluacion, new { alumnoId = alumnoId }).ConfigureAwait(false);
            }

            if (evaluaciones != null)
            {
                Log.Information("The item with id: '{id}' has been retrieved successfully", alumnoId);
                return evaluaciones;
            }
            else
            {
                Log.Error("The item with id: '{id}' has not been found in the database", alumnoId);
                return new List<Evaluacion>();
            }
        }

        public async Task<Evaluacion> GetEvaluacion(int id)
        {
            var queryEvaluacion = "SELECT * FROM evaluacion WHERE id = @id";
            var evaluacion = new Evaluacion();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                evaluacion = await connection.QueryFirstAsync<Evaluacion>(queryEvaluacion, new { id = id });
            }

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
            var queryInsertEvaluacion = @"INSERT INTO Evaluacion (alumnoId, asignaturaId, calificacion, comentario)
                                    VALUES (@alumnoId, @asignaturaId, @calificacion, @comentario)";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                await connection.ExecuteAsync(queryInsertEvaluacion, new { alumnoId = evaluacion.AlumnoId, asignaturaId = evaluacion.AsignaturaId, calificacion = evaluacion.Calificacion, comentario = evaluacion.Comentario });
            }

            Log.Information("A new item has been created successfully", evaluacion.Id);

            return evaluacion;
        }

        public async Task<bool> DeleteEvaluacion(int id)
        {
            var queryEvaluacion = "SELECT * FROM evaluacion WHERE id = @id";
            var evaluacion = new Evaluacion();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                evaluacion = await connection.QueryFirstAsync<Evaluacion>(queryEvaluacion, new { id = id });
            }

            if (evaluacion != null)
            {
                var queryDeleteEvaluacion = "DELETE FROM evaluacion WHERE id = @id";
                using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
                {
                    await connection.ExecuteAsync(queryDeleteEvaluacion, new { Id = id });
                }

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
            var queryEvaluacion = "SELECT * FROM evaluacion WHERE id = @id";
            var editedEvaluacion = new Evaluacion();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                editedEvaluacion = await connection.QueryFirstAsync<Evaluacion>(queryEvaluacion, new { id = evaluacion.Id });
            }

            if (editedEvaluacion != null)
            {
                editedEvaluacion.AlumnoId = evaluacion.AlumnoId;
                editedEvaluacion.AsignaturaId = evaluacion.AsignaturaId;
                editedEvaluacion.Calificacion = evaluacion.Calificacion;
                editedEvaluacion.Comentario = evaluacion.Comentario;
                //+ parameters

                var queryUpdateEvaluacion = @"UPDATE evaluacion 
                                        SET alumnoId = @alumnoId, asignaturaId = @asignaturaId, calificacion = @calificacion, comentario = @comentario
                                        WHERE id = @id";

                using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
                {
                    await connection.ExecuteAsync(queryUpdateEvaluacion, new { alumnoId = evaluacion.AlumnoId, asignaturaId = evaluacion.AsignaturaId, calificacion = evaluacion.Calificacion, comentario = evaluacion.Comentario, id = evaluacion.Id });
                }

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
