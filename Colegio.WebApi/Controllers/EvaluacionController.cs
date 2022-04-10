using AutoMapper;
using Colegio.Core.DTOs;
using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colegio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EvaluacionController : ControllerBase
    {
        private readonly IEvaluacionService _evaluacionService;
        private readonly IAlumnosService _alumnosService;
        private readonly IAsignaturasService _asignaturasService;
        private readonly IMapper _mapper;

        public EvaluacionController(IEvaluacionService evaluacionService, IAlumnosService alumnosService, IAsignaturasService asignaturasService, IMapper mapper)
        {
            _evaluacionService = evaluacionService;
            _alumnosService = alumnosService;
            _asignaturasService = asignaturasService;
            _mapper = mapper;
        }

        /// <summary>
        ///     Retrieve all qualifications
        /// </summary>
        /// <returns>List of all qualifications</returns>
        [HttpGet]
        public async Task<IActionResult> GetEvaluaciones()
        {
            var evaluaciones = await _evaluacionService.GetEvaluaciones();
            var evaluacionesDto = _mapper.Map<IEnumerable<EvaluacionDto>>(evaluaciones);

            foreach (var evaluacionDto in evaluacionesDto)
            {
                var alumno = await _alumnosService.GetAlumno(evaluacionDto.AlumnoId);

                if (alumno != null)
                {
                    evaluacionDto.Alumno = alumno.Nombre + ' ' + alumno.Apellidos;
                }

                var asignatura = await _asignaturasService.GetAsignatura(evaluacionDto.AsignaturaId);

                if (asignatura != null)
                {
                    evaluacionDto.Asignatura = asignatura.Nombre;
                }
            }

            return Ok(evaluacionesDto);
        }

        /// <summary>
        ///     Retrieve all qualifications by a student
        /// </summary>
        /// <returns>List of all qualifications about a student</returns>
        /// [HttpGet("int/{id:int}")]
        [HttpGet("GetEvaluaciones/{alumnoId}", Name = "GetEvaluaciones")]
        public async Task<IActionResult> GetEvaluaciones(int alumnoId)
        {
            var evaluaciones = await _evaluacionService.GetEvaluacionesPorAlumno(alumnoId);
            var evaluacionesDto = _mapper.Map<IEnumerable<EvaluacionDto>>(evaluaciones);

            foreach (var evaluacionDto in evaluacionesDto)
            {
                var alumno = await _alumnosService.GetAlumno(evaluacionDto.AlumnoId);

                if (alumno != null)
                {
                    evaluacionDto.Alumno = alumno.Nombre + ' ' + alumno.Apellidos;
                }

                var asignatura = await _asignaturasService.GetAsignatura(evaluacionDto.AsignaturaId);

                if (asignatura != null)
                {
                    evaluacionDto.Asignatura = asignatura.Nombre;
                }
            }

            return Ok(evaluacionesDto);
        }

        /// <summary>
        ///     Retrieve a qualification by its identifier
        /// </summary>
        /// <returns>One specific student</returns>
        [HttpGet("GetEvaluacion/{id}", Name = "GetEvaluacion")]
        public async Task<IActionResult> GetEvaluacion(int id)
        {
            var evaluacion = await _evaluacionService.GetEvaluacion(id);
            var evaluacionDto = _mapper.Map<EvaluacionDto>(evaluacion);

            var alumno = await _alumnosService.GetAlumno(evaluacion.AlumnoId);

            if (alumno != null)
            {
                evaluacionDto.Alumno = alumno.Nombre + ' ' + alumno.Apellidos;
            }

            var asignatura = await _asignaturasService.GetAsignatura(evaluacion.AsignaturaId);

            if (asignatura != null)
            {
                evaluacionDto.Asignatura = asignatura.Nombre;
            }

            return Ok(evaluacionDto);
        }

        /// <summary>
        ///     Create a qualification
        /// </summary>
        /// <returns>Created qualification</returns>
        [HttpPost]
        public async Task<IActionResult> CreateEvaluacion(Evaluacion evaluacion)
        {
            var newEvaluacion = await _evaluacionService.CreateEvaluacion(evaluacion);
            var evaluacionDto = _mapper.Map<EvaluacionDto>(newEvaluacion);
            return CreatedAtRoute("GetEvaluacion", new { newEvaluacion.Id }, evaluacionDto);
        }

        /// <summary>
        ///     Delete a qualification by its identifier
        /// </summary>
        /// <returns>true / false</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvaluacion(int id)
        {
            var response = await _evaluacionService.DeleteEvaluacion(id);
            return Ok(response);
        }

        /// <summary>
        ///     Edit a qualification
        /// </summary>
        /// <returns>true / false</returns>
        [HttpPut]
        public IActionResult EditEvaluacion([FromBody] Evaluacion evaluacion)
        {
            var response = _evaluacionService.EditEvaluacion(evaluacion);
            return Ok(response);
        }
    }
}
