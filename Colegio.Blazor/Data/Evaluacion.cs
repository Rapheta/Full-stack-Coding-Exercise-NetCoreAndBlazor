using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colegio.Blazor.Data
{
    public class Evaluacion
    {
        public int Id { get; set; }
        public int AlumnoId { get; set; }
        public string Alumno { get; set; }
        public int AsignaturaId { get; set; }
        public string Asignatura { get; set; }
        public double Calificacion { get; set; }
        public string Comentario { get; set; }
    }
}
