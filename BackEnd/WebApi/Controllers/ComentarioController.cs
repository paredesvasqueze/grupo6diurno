using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ComentarioController : ControllerBase
    {
        private readonly ComentarioDomain _ComentarioDomain;

        public ComentarioController(ComentarioDomain comentarioDomain)
        {
            _ComentarioDomain = comentarioDomain;
        }

        [HttpGet("ObtenerComentarioTodos")]
        public IActionResult ObtenerComentarioTodos()
        {
            var comentarios = _ComentarioDomain.ObtenerComentarioTodos();
            return Ok(comentarios);
        }

        [HttpPost("InsertarComentario")]
        public IActionResult InsertarComentario(Comentario oComentario)
        {
            var id = _ComentarioDomain.InsertarComentario(oComentario);
            return Ok(id);
        }

        [HttpPut("ActualizarComentario")]
        public IActionResult ActualizarComentario(Comentario oComentario)
        {
            try
            {
                var id = _ComentarioDomain.ActualizarComentario(oComentario);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al actualizar el comentario: {ex.Message}");
            }
        }

        [HttpDelete("EliminarComentario/{nIdComentario}")]
        public IActionResult EliminarComentario(Int32 nIdComentario)
        {
            var id = _ComentarioDomain.EliminarComentario(nIdComentario);
            return Ok(id);
        }
    }
}
