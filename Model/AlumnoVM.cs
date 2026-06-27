namespace CursosApp.Model
{
    public class AlumnoVM
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Foto { get; set; } = string.Empty;
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
    }
}
