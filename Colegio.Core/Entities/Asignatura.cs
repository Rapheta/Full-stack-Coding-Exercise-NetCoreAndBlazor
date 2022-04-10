using System;
using System.Collections.Generic;
using System.Text;

namespace Colegio.Core.Entities
{
    public class Asignatura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Curso { get; set; }
        public int ProfesorId { get; set; }
    }
}
