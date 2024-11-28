using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class GeneroController : ControllerBase
    {
        private readonly GeneroDomain _GeneroDomain;

        public GeneroController(GeneroDomain GeneroDomain)
        {
            _GeneroDomain = GeneroDomain;
        }

        [HttpGet("ObtenerGeneroTodos")]
        public IActionResult ObtenerGeneroTodos()
        {
            var Generos = _GeneroDomain.ObtenerGeneroTodos();
            return Ok(Generos); 
        }

        [HttpPost("InsertarGenero")]
        public IActionResult InsertarGenero(Genero oGenero)
        {
            var id = _GeneroDomain.InsertarGenero(oGenero);
            return Ok(id);
        }

        [HttpPut("ActualizarGenero")]
        public IActionResult ActualizarGenero(Genero oGenero)
        {
            try
            {
                var id = _GeneroDomain.ActualizarGenero(oGenero);
                return Ok(id);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error al actualizar el género: {ex.Message}");
            }
        }

        [HttpDelete("EliminarGenero/{nIdGenero}")]
        public IActionResult EliminarGenero(Int32 nIdGenero)
        {
            var id = _GeneroDomain.EliminarGenero(nIdGenero);
            return Ok(id);
        }
    }
}
