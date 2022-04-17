using AutoMapper;
using Colegio.Core.DTOs;
using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlumnosController : ControllerBase
    {
        private readonly IAlumnosService _alumnosService;
        private readonly IMapper _mapper;

        public AlumnosController(IAlumnosService alumnosServices, IMapper mapper)
        {
            _alumnosService = alumnosServices;
            _mapper = mapper;
        }

        /// <summary>
        ///     Retrieve all students
        /// </summary>
        /// <returns>List of all students</returns>
        [HttpGet]
        public async Task<IActionResult> GetAlumnos()
        {
            var alumnos = await _alumnosService.GetAlumnos();
            var alumnosDto = _mapper.Map<IEnumerable<AlumnoDto>>(alumnos);
            return Ok(alumnosDto);
        }

        /// <summary>
        ///     Retrieve a student by its identifier
        /// </summary>
        /// <returns>One specific student</returns>
        [HttpGet("{id}", Name = "GetAlumno")]
        public async Task<IActionResult> GetAlumno(int id)
        {
            var alumno = await _alumnosService.GetAlumno(id);
            var alumnoDto = _mapper.Map<AlumnoDto>(alumno);
            return Ok(alumnoDto);
        }

        /// <summary>
        ///     Create a student
        /// </summary>
        /// <returns>Created student</returns>
        [HttpPost]
        public async Task<IActionResult> CreateAlumno(Alumno alumno)
        {
            var newAlumno = await _alumnosService.CreateAlumno(alumno);
            var alumnoDto = _mapper.Map<AlumnoDto>(newAlumno);
            return CreatedAtRoute("GetAlumno", new { newAlumno.Id }, alumnoDto);
        }

        /// <summary>
        ///     Delete a student by its identifier
        /// </summary>
        /// <returns>true / false</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlumno(int id)
        {
            var response = await _alumnosService.DeleteAlumno(id);
            return Ok(response);
        }

        /// <summary>
        ///     Edit a student
        /// </summary>
        /// <returns>true / false</returns>
        [HttpPut]
        public IActionResult EditAlumno([FromBody] Alumno alumno)
        {
            var response = _alumnosService.EditAlumno(alumno);
            return Ok(response);
        }
    }
}
