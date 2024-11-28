using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class LibroController : ControllerBase
    {
        private readonly LibroDomain _LibroDomain;

        public LibroController(LibroDomain libroDomain)
        {
            _LibroDomain = libroDomain;
        }

        [HttpGet("ObtenerLibroTodos")]
        public IActionResult ObtenerLibroTodos()
        {
            var libros = _LibroDomain.ObtenerLibroTodos();
            return Ok(libros);
        }

        [HttpPost("InsertarLibro")]
        public IActionResult InsertarLibro(Libro oLibro)
        {
            var id = _LibroDomain.InsertarLibro(oLibro);
            return Ok(id);
        }

        [HttpPut("ActualizarLibro")]
        public IActionResult ActualizarLibro(Libro oLibro)
        {
            try
            {
                var id = _LibroDomain.ActualizarLibro(oLibro);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al actualizar el libro: {ex.Message}");
            }
        }

        [HttpDelete("EliminarLibro/{nIdLibro}")]
        public IActionResult EliminarLibro(Int32 nIdLibro)
        {
            var id = _LibroDomain.EliminarLibro(nIdLibro);
            return Ok(id);
        }
    }
}
