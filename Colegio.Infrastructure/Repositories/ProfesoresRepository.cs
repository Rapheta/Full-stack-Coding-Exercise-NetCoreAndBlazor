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
    public class ProfesoresRepository : IProfesoresRepository
    {
        private readonly IConfiguration _configuration;

        public ProfesoresRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Profesor>> GetProfesores()
        {
            var queryProfesores = "SELECT * FROM profesor";
            var profesores = new List<Profesor>();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                profesores = (List<Profesor>)await connection.QueryAsync<Profesor>(queryProfesores).ConfigureAwait(false);
            }

            Log.Information("All the existing items have been retrieved successfully");
            return profesores;
        }

        public async Task<Profesor> GetProfesor(int id)
        {
            var queryProfesor = "SELECT * FROM profesor WHERE id = @id";
            var profesor = new Profesor();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                profesor = await connection.QueryFirstAsync<Profesor>(queryProfesor, new { id = id });
            }

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
            var queryInsertProfesor = @"INSERT INTO Profesor (nombre, apellidos, area)
                                    VALUES (@nombre, @apellidos, @area)";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                await connection.ExecuteAsync(queryInsertProfesor, new { nombre = profesor.Nombre, apellidos = profesor.Apellidos, area = profesor.Area });
            }

            Log.Information("A new item has been created successfully", profesor.Id);

            return profesor;
        }

        public async Task<bool> DeleteProfesor(int id)
        {
            var queryProfesor = "SELECT * FROM profesor WHERE id = @id";
            var profesor = new Profesor();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                profesor = await connection.QueryFirstAsync<Profesor>(queryProfesor, new { id = id });
            }

            if (profesor != null)
            {
                var queryDeleteProfesor = "DELETE FROM profesor WHERE id = @id";
                using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
                {
                    await connection.ExecuteAsync(queryDeleteProfesor, new { Id = id });
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

        public async Task<bool> EditProfesor(Profesor profesor)
        {
            var queryProfesor = "SELECT * FROM profesor WHERE id = @id";
            var editedProfesor = new Profesor();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                editedProfesor = await connection.QueryFirstAsync<Profesor>(queryProfesor, new { id = profesor.Id });
            }

            if (editedProfesor != null)
            {
                editedProfesor.Nombre = profesor.Nombre;
                editedProfesor.Apellidos = profesor.Apellidos;
                editedProfesor.Area = profesor.Area;
                //+ parameters

                var queryUpdateProfesor = @"UPDATE profesor 
                                        SET nombre = @nombre, apellidos = @apellidos, area = @area
                                        WHERE id = @id";

                using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
                {
                    await connection.ExecuteAsync(queryUpdateProfesor, new { nombre = profesor.Nombre, apellidos = profesor.Apellidos, area = profesor.Area, id = profesor.Id });
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
