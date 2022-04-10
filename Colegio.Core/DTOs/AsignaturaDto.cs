namespace Colegio.Core.DTOs
{
    public class AsignaturaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Curso { get; set; }
        public int ProfesorId { get; set; }
        public string ProfesorNombre { get; set; }
    }
}
