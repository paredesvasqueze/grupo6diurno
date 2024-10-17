using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SancionController : ControllerBase
    {
        private readonly SancionDomain _SancionDomain;

        public SancionController(SancionDomain sancionDomain)
        {
            _SancionDomain = sancionDomain;
        }

        [HttpGet("ObtenerSancionTodos")]
        public IActionResult ObtenerSancionTodos()
        {
            var sanciones = _SancionDomain.ObtenerSancionTodos();
            return Ok(sanciones);
        }

        [HttpPost("InsertarSancion")]
        public IActionResult InsertarSancion(Sancion oSancion)
        {
            var id = _SancionDomain.InsertarSancion(oSancion);
            return Ok(id);
        }

        [HttpPut("ActualizarSancion")]
        public IActionResult ActualizarSancion(Sancion oSancion)
        {
            try
            {
                var id = _SancionDomain.ActualizarSancion(oSancion);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al actualizar la sanción: {ex.Message}");
            }
        }

        [HttpDelete("EliminarSancion")]
        public IActionResult EliminarSancion(int nId_Sancion)
        {
            try
            {
                var id = _SancionDomain.EliminarSancion(nId_Sancion);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al eliminar la sanción: {ex.Message}");
            }
        }
    }
}
