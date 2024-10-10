using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComentarioController : ControllerBase
    {
        private readonly ComentarioDomain _ComentarioDomain;

        public ComentarioController(ComentarioDomain ComentarioDomain)
        {
            _ComentarioDomain = ComentarioDomain;
        }

        [HttpGet("ObtenerComentarioTodos")]
        public IActionResult ObtenerComentarioTodos()
        {
            var Comentarios = _ComentarioDomain.ObtenerComentarioTodos();
            return Ok(Comentarios);
        }

        [HttpPost("InsertarComentario")]
        public IActionResult InsertarComentario(Comentario oComentario)
        {
            var id = _ComentarioDomain.InsertarComentario(oComentario);
            return Ok(id);
        }

        [HttpDelete("EliminarComentarioTodos")]
        public IActionResult EliminarComentarioTodos()
        {
            // Implementa la lógica de eliminación si es necesario
            return Ok("Método no implementado");
        }

        [HttpPut("ActualizarComentario")]
        public IActionResult ActualizarComentario(Comentario oComentario)
        {
            var id = _ComentarioDomain.ActualizarComentario(oComentario); // Cambiado a `ActualizarComentario`
            return Ok(id);
        }
    }
}
