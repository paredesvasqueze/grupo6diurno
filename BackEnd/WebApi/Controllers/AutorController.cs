using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly AutorDomain _AutorDomain;

        public AutorController(AutorDomain autorDomain)
        {
            _AutorDomain = autorDomain;
        }

        [HttpGet("ObtenerAutorTodos")]
        public IActionResult ObtenerAutorTodos()
        {
            var autores = _AutorDomain.ObtenerAutorTodos();
            return Ok(autores);
        }

        [HttpPost("InsertarAutor")]
        public IActionResult InsertarAutor(Autor oAutor)
        {
            var id = _AutorDomain.InsertarAutor(oAutor);
            return Ok(id);
        }

        [HttpPut("ActualizarAutor")]
        public IActionResult ActualizarAutor(Autor oAutor)
        {
            try
            {
                var id = _AutorDomain.ActualizarAutor(oAutor);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al actualizar el autor: {ex.Message}");
            }
        }

        [HttpDelete("EliminarAutor/{nIdAutor}")]
        public IActionResult EliminarAutor(Int32 nIdAutor)
        {
            var id = _AutorDomain.EliminarAutor(nIdAutor);
            return Ok(id);
        }
    }
}