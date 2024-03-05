using Escuela.Api.Entities;
using Escuela.Api.Models.Alumno.Request;

namespace Escuela.Api.Interface
{
    public interface IRepositorioAlumno
    {
        Task<bool> Delete(int id);
        Task<List<Alumno>> GetAlumnoAsync();
        Task<Alumno> GetById(int id);
        Task<Alumno> Registro(AlumnoRequest request);
        Task<Alumno> Update(AlumnoRequest request);
    }
}
