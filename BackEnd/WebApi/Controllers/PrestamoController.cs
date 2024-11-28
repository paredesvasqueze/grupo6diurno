using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PrestamoController : ControllerBase
    {
        private readonly PrestamoDomain _PrestamoDomain;

        public PrestamoController(PrestamoDomain prestamoDomain)
        {
            _PrestamoDomain = prestamoDomain;
        }

        [HttpGet("ObtenerPrestamoTodos")]
        public IActionResult ObtenerPrestamoTodos()
        {
            var prestamos = _PrestamoDomain.ObtenerPrestamoTodos();
            return Ok(prestamos);
        }

        [HttpPost("InsertarPrestamo")]
        public IActionResult InsertarPrestamo(Prestamo oPrestamo)
        {
            var id = _PrestamoDomain.InsertarPrestamo(oPrestamo);
            return Ok(id);
        }

        [HttpPut("ActualizarPrestamo")]
        public IActionResult ActualizarPrestamo(Prestamo oPrestamo)
        {
            try
            {
                var id = _PrestamoDomain.ActualizarPrestamo(oPrestamo);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al actualizar el préstamo: {ex.Message}");
            }
        }

        [HttpDelete("EliminarPrestamo/{nIdPrestamo}")]
        public IActionResult EliminarPrestamo(Int32 nIdPrestamo)
        {
            var id = _PrestamoDomain.EliminarPrestamo(nIdPrestamo);
            return Ok(id);
        }
    }
}
