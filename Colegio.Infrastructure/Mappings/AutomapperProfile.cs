using AutoMapper;
using Colegio.Core.DTOs;
using Colegio.Core.Entities;

namespace Colegio.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Alumno, AlumnoDto>();
            CreateMap<AlumnoDto, Alumno>();
            CreateMap<Profesor, ProfesorDto>();
            CreateMap<ProfesorDto, Profesor>();
            CreateMap<Asignatura, AsignaturaDto>();
            CreateMap<AsignaturaDto, Asignatura>();
            CreateMap<Evaluacion, EvaluacionDto>();
            CreateMap<EvaluacionDto, Evaluacion>();
        }
    }
}
