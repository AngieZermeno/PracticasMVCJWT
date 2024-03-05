using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly string _conn;

        public AlumnoController(IConfiguration configuration)
        {
            _conn = configuration.GetConnectionString("DefaultConnection");
        }

        //[HttpGet]
        //[Route("Lista")]
        //public IActionResult Lista ()
        //{
        //    List<Alu>
        //}
    }
}
