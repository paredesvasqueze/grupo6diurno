using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibroController : ControllerBase
    {
        private readonly LibroDomain _LibroDomain;

        public LibroController(LibroDomain LibroDomain)
        {
            _LibroDomain = LibroDomain;
        }

        [HttpGet("ObtenerLibroTodos")]
        public List<Libro>ObtenerLibroTodos()
        {
            throw new NotImplementedException();
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
            var id = _LibroDomain.ActualizarLibro(oLibro);
            return Ok(id);
        }

        [HttpDelete("EliminarLibro")]
        public IActionResult EliminarLibro(int id)
        {
            try
            {
                _LibroDomain.EliminarLibro(id);
                return Ok("Libro eliminado exitosamente.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al eliminar el libro: {ex.Message}");
            }
        }

    }
}
