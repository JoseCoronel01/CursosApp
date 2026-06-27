namespace CursosApp.Model
{
    public class UsuarioVM
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public byte[] Pass { get; set; } = Array.Empty<byte>();
        public DateTime FechaAlta { get; set; }
        public int IdRol { get; set; }
    }
}
