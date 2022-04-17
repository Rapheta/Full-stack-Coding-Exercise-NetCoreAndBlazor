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
    public class AsignaturasRepository : IAsignaturasRepository
    {
        private readonly IConfiguration _configuration;
        public AsignaturasRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Asignatura>> GetAsignaturas()
        {
            var queryAsignaturas = "SELECT * FROM asignatura";
            var asignaturas = new List<Asignatura>();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                asignaturas = (List<Asignatura>)await connection.QueryAsync<Asignatura>(queryAsignaturas).ConfigureAwait(false);
            }

            Log.Information("All the existing items have been retrieved successfully");
            return asignaturas;
        }

        public async Task<Asignatura> GetAsignatura(int id)
        {
            var queryAsignatura = "SELECT * FROM asignatura WHERE id = @id";
            var asignatura = new Asignatura();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                asignatura = await connection.QueryFirstAsync<Asignatura>(queryAsignatura, new { id = id });
            }

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
            var queryInsertAsignatura = @"INSERT INTO asignatura (nombre, curso, profesorId)
                                    VALUES (@nombre, @curso, @profesorId)";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                await connection.ExecuteAsync(queryInsertAsignatura, new { nombre = asignatura.Nombre, curso = asignatura.Curso, profesorId = asignatura.ProfesorId });
            }

            Log.Information("A new item has been created successfully", asignatura.Id);

            return asignatura;
        }

        public async Task<bool> DeleteAsignatura(int id)
        {
            var queryAsignatura = "SELECT * FROM asignatura WHERE id = @id";
            var asignatura = new Asignatura();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                asignatura = await connection.QueryFirstAsync<Asignatura>(queryAsignatura, new { id = id });
            }

            if (asignatura != null)
            {
                var queryDeleteAsignatura = "DELETE FROM asignatura WHERE id = @id";
                using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
                {
                    await connection.ExecuteAsync(queryDeleteAsignatura, new { Id = id });
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

        public async Task<bool> EditAsignatura(Asignatura asignatura)
        {
            var queryAsignatura = "SELECT * FROM asignatura WHERE id = @id";
            var editedAsignatura = new Asignatura();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
            {
                editedAsignatura = await connection.QueryFirstAsync<Asignatura>(queryAsignatura, new { id = asignatura.Id });
            }

            if (editedAsignatura != null)
            {
                editedAsignatura.Nombre = asignatura.Nombre;
                editedAsignatura.Curso = asignatura.Curso;
                editedAsignatura.ProfesorId = asignatura.ProfesorId;
                //+ parameters

                var queryUpdateAsignatura = @"UPDATE asignatura 
                                        SET nombre = @nombre, curso = @curso, profesorId = @profesorId 
                                        WHERE id = @id";

                using (var connection = new SqlConnection(_configuration.GetConnectionString("BlazorCrud")))
                {
                    await connection.ExecuteAsync(queryUpdateAsignatura, new { nombre = asignatura.Nombre, curso = asignatura.Curso, profesorId = asignatura.ProfesorId, id = asignatura.Id });
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
