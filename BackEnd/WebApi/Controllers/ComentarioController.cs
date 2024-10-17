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

        [HttpDelete("EliminarComentario")]
        public IActionResult EliminarComentario(int nId_Comentario)
        {
            try
            {
                var id = _ComentarioDomain.EliminarComentario(nId_Comentario);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al eliminar el comentario: {ex.Message}");
            }
        }
    }
}
