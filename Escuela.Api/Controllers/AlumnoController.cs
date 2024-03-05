using AutoMapper;
using Escuela.Api.Entities;
using Escuela.Api.Interface;
using Escuela.Api.Models.Alumno.Request;
using Escuela.Api.Models.Alumno.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Escuela.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly IRepositorioAlumno _repositorioAlumno;
        private readonly IMapper _mapper;

        public AlumnoController(IRepositorioAlumno repositorioAlumno, IMapper mapper)
        {
            _repositorioAlumno = repositorioAlumno;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<AlumnoResponse>> GetAlumnos ()
        {
            var response = await _repositorioAlumno.GetAlumnoAsync();
            var  alumResponse = _mapper.Map<List<Alumno>, List<AlumnoResponse>>(response);

            return alumResponse;
        }

        [HttpGet("{id}")]
        public async Task<AlumnoResponse> GetAlumnosId (int id)
        {
            var resultTask = await _repositorioAlumno.GetById(id);

            return _mapper.Map<Alumno,AlumnoResponse>(resultTask);
        }

        [HttpPost]
        public async Task<AlumnoResponse> Create (AlumnoRequest request)
        {
            var resultTask = await _repositorioAlumno.Registro(request);

            return _mapper.Map<Alumno, AlumnoResponse>(resultTask);
        }

        [HttpPut]
        public async Task<AlumnoResponse> UpdateAlumno (AlumnoRequest request)
        {
            var resultTask = await _repositorioAlumno.Update(request);

            return _mapper.Map<Alumno, AlumnoResponse>(resultTask);
        }

        [HttpDelete]
        public async Task<bool> Delete (int id)
        {
            return await _repositorioAlumno.Delete(id);
        }


    }
}
