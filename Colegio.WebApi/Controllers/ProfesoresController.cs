using AutoMapper;
using Colegio.Core.DTOs;
using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfesoresController : Controller
    {
        private readonly IProfesoresService _profesoresService;
        private readonly IMapper _mapper;

        public ProfesoresController(IProfesoresService profesoresServices, IMapper mapper)
        {
            _profesoresService = profesoresServices;
            _mapper = mapper;
        }

        /// <summary>
        ///     Retrieve all teachers
        /// </summary>
        /// <returns>List of all teachers</returns>
        [HttpGet]
        public async Task<IActionResult> GetProfesores()
        {
            var profesores = await _profesoresService.GetProfesores();
            var profesoresDto = _mapper.Map<IEnumerable<ProfesorDto>>(profesores);
            return Ok(profesoresDto);
        }

        /// <summary>
        ///     Retrieve a teacher by its identifier
        /// </summary>
        /// <returns>One specific teacher</returns>
        [HttpGet("{id}", Name = "GetProfesor")]
        public async Task<IActionResult> GetProfesor(int id)
        {
            var profesor = await _profesoresService.GetProfesor(id);
            var profesorDto = _mapper.Map<ProfesorDto>(profesor);
            return Ok(profesorDto);
        }

        /// <summary>
        ///     Create a teacher
        /// </summary>
        /// <returns>Created teacher</returns>
        [HttpPost]
        public async Task<IActionResult> CreateProfesor(Profesor profesor)
        {
            var newProfesor = await _profesoresService.CreateProfesor(profesor);
            var profesorDto = _mapper.Map<ProfesorDto>(newProfesor);
            return CreatedAtRoute("GetProfesor", new { newProfesor.Id }, profesorDto);
        }

        /// <summary>
        ///     Delete a teacher by its identifier
        /// </summary>
        /// <returns>true / false</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfesor(int id)
        {
            var response = await _profesoresService.DeleteProfesor(id);
            return Ok(response);
        }

        /// <summary>
        ///     Edit a teacher
        /// </summary>
        /// <returns>true / false</returns>
        [HttpPut]
        public IActionResult EditProfesor([FromBody] Profesor profesor)
        {
            var response = _profesoresService.EditProfesor(profesor);
            return Ok(response);
        }
    }
}
