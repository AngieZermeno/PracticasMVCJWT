using System.ComponentModel.DataAnnotations.Schema;

namespace ApiJWT.Entities
{
    public class Horario
    {
        public int Id { get; set; }

        //[NotMapped]
        //public List<Materia> Materia { get; set; }

        public ICollection<Alumno> AlumnoHorario { get; set; }
        public TimeSpan Entrada { get; set; }
        public TimeSpan Salida { get; set; }
    }
}
