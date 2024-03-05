using AutoMapper;
using Escuela.Api.Entities;
using Escuela.Api.Models.Alumno.Response;

namespace Escuela.Api.Persistence
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Alumno, AlumnoResponse>();        
        }
    }
}
