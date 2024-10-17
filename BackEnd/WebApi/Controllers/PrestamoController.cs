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

        [HttpDelete("EliminarPrestamo")]
        public IActionResult EliminarPrestamo(int nId_Prestamo)
        {
            try
            {
                var id = _PrestamoDomain.EliminarPrestamo(nId_Prestamo);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al eliminar el préstamo: {ex.Message}");
            }
        }
    }
}
