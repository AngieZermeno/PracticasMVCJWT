namespace Escuela.Api.Entities
{
    public class Alumno
    {
        public int? Id { get; set; }
        public string NoControl { get; set; }
        public string Nombre { get; set; }
        public string ApelidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
