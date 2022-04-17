using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Infrastructure.Repositories
{
    public class AlumnosRepository : IAlumnosRepository
    {
        private readonly IConfiguration _configuration;
        public AlumnosRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Alumno>> GetAlumnos()
        {
            var queryAlumnos = "SELECT * FROM alumno";
            var alumnos = new List<Alumno>();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                alumnos = (List<Alumno>)await connection.QueryAsync<Alumno>(queryAlumnos).ConfigureAwait(false);
            }

            Log.Information("All the existing items have been retrieved successfully");
            return alumnos;
        }

        public async Task<Alumno> GetAlumno(int id)
        {
            var queryAlumno = "SELECT * FROM alumno WHERE id = @id";
            var alumno = new Alumno();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                alumno = await connection.QueryFirstAsync<Alumno>(queryAlumno, new { id = id });
            }

            if (alumno != null)
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
            var queryInsertAlumno = @"INSERT INTO Alumno (nombre, apellidos, curso)
                                    VALUES (@nombre, @apellidos, @curso)";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                await connection.ExecuteAsync(queryInsertAlumno, new { nombre = alumno.Nombre, apellidos = alumno.Apellidos, curso = alumno.Curso});
            }

            Log.Information("A new item has been created successfully", alumno.Id);

            return alumno;
        }

        public async Task<bool> DeleteAlumno(int id)
        {
            var queryAlumno = "SELECT * FROM alumno WHERE id = @id";
            var alumno = new Alumno();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                alumno = await connection.QueryFirstAsync<Alumno>(queryAlumno, new { id = id });
            }

            if (alumno != null)
            {
                var queryDeleteAlumno = "DELETE FROM alumno WHERE id = @id";
                using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
                {
                    await connection.ExecuteAsync(queryDeleteAlumno, new { Id = id });
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

        public async Task<bool> EditAlumno(Alumno alumno)
        {
            var queryAlumno = "SELECT * FROM alumno WHERE id = @id";
            var editedAlumno = new Alumno();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                editedAlumno = await connection.QueryFirstAsync<Alumno>(queryAlumno, new { id = alumno.Id });
            }

            if (editedAlumno != null)
            {
                editedAlumno.Nombre = alumno.Nombre;
                editedAlumno.Apellidos = alumno.Apellidos;
                editedAlumno.Curso = alumno.Curso;
                //+ parameters

                var queryUpdateAlumno = @"UPDATE Alumno 
                                        SET nombre = @nombre, apellidos = @apellidos, curso = @curso
                                        WHERE id = @id";

                using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
                {
                    await connection.ExecuteAsync(queryUpdateAlumno, new { nombre = alumno.Nombre, apellidos = alumno.Apellidos, curso = alumno.Curso, id = alumno.Id });
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
