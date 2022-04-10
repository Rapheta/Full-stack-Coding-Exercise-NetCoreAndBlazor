namespace Colegio.Blazor.Data
{
    public class Asignatura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Curso { get; set; }
        public int ProfesorId { get; set; }
        public string ProfesorNombre { get; set; }
    }
}
