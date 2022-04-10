using System;
using System.Collections.Generic;
using System.Text;

namespace Colegio.Core.Entities
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Curso { get; set; }
    }
}
