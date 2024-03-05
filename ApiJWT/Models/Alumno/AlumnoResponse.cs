using ApiJWT.Entities;

namespace ApiJWT.Models.Alumno
{
    public class AlumnoResponse
    {
        public int Id { get; set; }
        public string NoControl { get; set; }
        public string Nombre { get; set; }
        public string ApelidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }

        //Relacion Uno A Muchos, un alumno tiene un solo horario
        public int HorarioId { get; set; }
        public Horario Horario { get; set; }
    }
}
