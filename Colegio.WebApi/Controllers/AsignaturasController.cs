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
    public class AsignaturasController : ControllerBase
    {
        private readonly IAsignaturasService _asignaturasService;
        private readonly IProfesoresService _profesoresService;
        private readonly IMapper _mapper;

        public AsignaturasController(IAsignaturasService asignaturasService, IProfesoresService profesoresServices, IMapper mapper)
        {
            _asignaturasService = asignaturasService;
            _profesoresService = profesoresServices;
            _mapper = mapper;
        }

        /// <summary>
        ///     Retrieve all subjects
        /// </summary>
        /// <returns>List of all subjects</returns>
        [HttpGet]
        public async Task<IActionResult> GetAsignaturas()
        {
            var asignaturas = await _asignaturasService.GetAsignaturas();
            var asignaturasDto = _mapper.Map<IEnumerable<AsignaturaDto>>(asignaturas);

            var profesores = await _profesoresService.GetProfesores();

            foreach (var asignaturaDto in asignaturasDto)
            {
                if(profesores.FirstOrDefault(x => x.Id == asignaturaDto.ProfesorId) != null)
                {
                    asignaturaDto.ProfesorNombre = profesores.FirstOrDefault(x => x.Id == asignaturaDto.ProfesorId).Nombre + ' ' + profesores.FirstOrDefault(x => x.Id == asignaturaDto.ProfesorId).Apellidos;
                }
            }

            return Ok(asignaturasDto);
        }

        /// <summary>
        ///     Retrieve a subject by its identifier
        /// </summary>
        /// <returns>One specific subject</returns>
        [HttpGet("{id}", Name = "GetAsignatura")]
        public async Task<IActionResult> GetAsignatura(int id)
        {
            var asignatura = await _asignaturasService.GetAsignatura(id);
            var asignaturaDto = _mapper.Map<AsignaturaDto>(asignatura);
            return Ok(asignaturaDto);
        }

        /// <summary>
        ///     Create a subject
        /// </summary>
        /// <returns>Created subject</returns>
        [HttpPost]
        public async Task<IActionResult> Createasignatura(Asignatura asignatura)
        {
            var newAsignatura = await _asignaturasService.CreateAsignatura(asignatura);
            var asignaturaDto = _mapper.Map<AsignaturaDto>(newAsignatura);
            return CreatedAtRoute("GetAsignatura", new { newAsignatura.Id }, asignaturaDto);
        }

        /// <summary>
        ///     Delete a subject by its identifier
        /// </summary>
        /// <returns>true / false</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsignatura(int id)
        {
            var response = await _asignaturasService.DeleteAsignatura(id);
            return Ok(response);
        }

        /// <summary>
        ///     Edit a subject
        /// </summary>
        /// <returns>true / false</returns>
        [HttpPut]
        public IActionResult EditAsignatura([FromBody] Asignatura asignatura)
        {
            var response = _asignaturasService.EditAsignatura(asignatura);
            return Ok(response);
        }
    }
}
