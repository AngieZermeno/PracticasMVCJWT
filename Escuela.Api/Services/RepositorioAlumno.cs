using Dapper;
using Escuela.Api.Entities;
using Escuela.Api.Interface;
using Escuela.Api.Models.Alumno.Request;
using Escuela.Api.Models.Alumno.Response;
using Escuela.Api.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Escuela.Api.Services
{
    public class RepositorioAlumno : IRepositorioAlumno
    {
        private readonly string _conn;

        private readonly AplicationDBContext _context;
        public RepositorioAlumno(IConfiguration configuration, AplicationDBContext context )
        {
            _context = context;
            _conn = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<Alumno>> GetAlumnoAsync()
        {
            return await _context.Alumno.ToListAsync();
        }

        public async Task<Alumno> GetById(int id)
        {
            return await _context.Alumno.FirstOrDefaultAsync(a => a.Id == id);          
        }

        public async Task<Alumno> Registro (AlumnoRequest request)
        {
            var registro = new Alumno
            {
                NoControl = request.NoControl,
                Nombre = request.Nombre,
                ApelidoMaterno = request.ApelidoMaterno,
                FechaNacimiento = request.FechaNacimiento,
                ApellidoPaterno = request.ApellidoPaterno
            };

            _context.Alumno.Add(registro);

            var result = await _context.SaveChangesAsync();

            if (result > 0) return await _context.Alumno.FirstOrDefaultAsync(x => x.Id == registro.Id);           
           
            else throw new Exception("No se pudo insertar el nuevo registro en la BD");
        }

        public async Task<Alumno> Update (AlumnoRequest request)
        {
            var registro = new Alumno();

            registro = _context.Alumno.FirstOrDefault(x => x.Id == request.Id);

            if (registro == null) throw new Exception("No se encontró el registro");

            registro.NoControl = request.NoControl;
            registro.Nombre = request.Nombre;
            registro.ApelidoMaterno = request.ApelidoMaterno;
            registro.FechaNacimiento = request.FechaNacimiento;
            registro.ApellidoPaterno = request.ApellidoPaterno;           

            var exito = await _context.SaveChangesAsync();

            if (exito > 0) return await _context.Alumno.FirstOrDefaultAsync(x => x.Id == request.Id);

            else throw new Exception("No se pudo actualizar el valor en la base de datos");

        }

        public async Task<bool> Delete (int id)
        {
            var alumno = _context.Alumno.FirstOrDefault(x=>x.Id == id);

            if (alumno == null) throw new Exception("ALumno no encontrado");

            _context.Alumno.Remove(alumno);

            var result = await _context.SaveChangesAsync();

            if (result > 0) return true;
            else throw new Exception("Ocurrió un error al borrar en la base de datos");
        }
    }
}
