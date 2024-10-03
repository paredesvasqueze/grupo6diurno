using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly AutorDomain _AutorDomain;

        public AutorController(AutorDomain AutorDomain)
        {
            _AutorDomain = AutorDomain;
        }

        [HttpGet("ObtenerAutorTodos")]
        public IActionResult ObtenerAutorTodos()
        {
            var Autors = _AutorDomain.ObtenerAutorTodos();
            return Ok(Autors);
        }

        [HttpPost("InsertAutor")]
        public IActionResult InsertAutor(Autor oAutor)
        {
            var id = _AutorDomain.InsertarAutor(oAutor);
            return Ok(id);
        }

        [HttpDelete("EliminarAutorTodos")]
        public IActionResult EliminarAutorTodos()
        {
            var Autors = _AutorDomain.ObtenerAutorTodos();
            return Ok(Autors);
        }

        [HttpPut("ActualizarAutor")]
        public IActionResult ActualizarAutor(Autor oAutor)
        {
            var id = _AutorDomain.InsertarAutor(oAutor);
            return Ok(id);
        }
    }
}
