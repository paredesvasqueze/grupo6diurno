using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrestamoController : ControllerBase
    {
        private readonly PrestamoDomain _PrestamoDomain;

        public PrestamoController(PrestamoDomain PrestamoDomain)
        {
            _PrestamoDomain = PrestamoDomain;
        }

        [HttpGet("ObtenerPrestamoTodos")]
        public IActionResult ObtenerPrestamoTodos()
        {
            var Prestamos = _PrestamoDomain.ObtenerPrestamoTodos();
            return Ok(Prestamos);
        }

        [HttpPost("InsertarPrestamo")]
        public IActionResult InsertarPrestamo(Prestamo oPrestamo)
        {
            var id = _PrestamoDomain.InsertarPrestamo(oPrestamo);
            return Ok(id);
        }

        [HttpDelete("EliminarPrestamoTodos")]
        public IActionResult EliminarPrestamoTodos()
        {
            
            return Ok("Método no implementado");
        }

        [HttpPut("ActualizarPrestamo")]
        public IActionResult ActualizarPrestamo(Prestamo oPrestamo)
        {
            var id = _PrestamoDomain.ActualizarPrestamo(oPrestamo);
            return Ok(id);
        }
    }
}
