using Escuela.Api.Models.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Escuela.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly string SecretKey;

        public AuthenticationController(IConfiguration configuration)
        {
            SecretKey = configuration.GetSection("setting").GetSection("secretkey").ToString();
        }   

        [HttpPost]
        [Route("Acceder")]
        public IActionResult validar([FromBody] Usuario request)
        {
            if(request.Correo == "angie.oz927@gmail.com" && request.Clave == "123")
            {
                var keyBytes = Encoding.ASCII.GetBytes(SecretKey);
                var claims = new ClaimsIdentity();

                claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, request.Correo)); //los cleims son solicitudes de permisos

                // aqui se crea el token
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = claims,
                    Expires = DateTime.UtcNow.AddMinutes(3),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);

                string tokenObtenido = tokenHandler.WriteToken(token);

                return StatusCode(StatusCodes.Status200OK, new { tokenObtenido });
            }

            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new { token = "" });
            }
        }
    }
}
