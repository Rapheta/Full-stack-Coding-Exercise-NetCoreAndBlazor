using System;
using System.Collections.Generic;
using System.Text;

namespace Colegio.Core.Entities
{
    public class Evaluacion
    {
        public int Id { get; set; }
        public int AlumnoId { get; set; }
        public int AsignaturaId { get; set; }
        public double Calificacion { get; set; }
        public string Comentario { get; set; }
    }
}
