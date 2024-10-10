using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;

namespace WebApi.Controllers
{
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

        [HttpDelete("EliminarGenero")]
        public IActionResult EliminarGenero(int nId_Genero)
        {
            try
            {
                var id = _GeneroDomain.EliminarGenero(nId_Genero);
                return Ok(id);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error al eliminar el género: {ex.Message}");
            }
        }


    }
}
