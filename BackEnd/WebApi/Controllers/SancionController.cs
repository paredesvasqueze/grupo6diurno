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

        public SancionController(SancionDomain SancionDomain)
        {
            _SancionDomain = SancionDomain;
        }

        [HttpGet("ObtenerSancionTodos")]
        public IActionResult ObtenerSancionTodos()
        {
            var Sancions = _SancionDomain.ObtenerSancionTodos();
            return Ok(Sancions);
        }

        [HttpPost("InsertarSancion")]
        public IActionResult InsertarSancion(Sancion oSancion)
        {
            var id = _SancionDomain.InsertarSancion(oSancion);
            return Ok(id);
        }

        [HttpDelete("EliminarSancionTodos")]
        public IActionResult EliminarSancionTodos()
        {
            // Implementa la lógica de eliminación si es necesario
            return Ok("Método no implementado");
        }

        [HttpPut("ActualizarSancion")]
        public IActionResult ActualizarSancion(Sancion oSancion)
        {
            var id = _SancionDomain.ActualizarSancion(oSancion); // Cambiado a `ActualizarSancion`
            return Ok(id);
        }
    }
}
