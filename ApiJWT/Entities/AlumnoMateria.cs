namespace ApiJWT.Entities
{
    public class AlumnoMateria
    {
        public int Id { get; set; }
        public Alumno Alumno { get; set; }
        public Materia Materia { get; set; }
    }
}
