namespace Escuela.Api.Entities
{
    public class Horario
    {
        public int Id { get; set; }
        public TimeSpan Entrada { get; set; }
        public TimeSpan Salida { get; set; }
        public Materia Materia { get; set; }
        public Maestro Maestro { get; set; }
        public DiasSemana Dia { get; set; }
        public DateTime Fecha { get; set; }
    }
}
