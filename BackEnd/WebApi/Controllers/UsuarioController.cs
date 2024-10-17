using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioDomain _UsuarioDomain;

        public UsuarioController(UsuarioDomain usuarioDomain)
        {
            _UsuarioDomain = usuarioDomain;
        }

        [HttpGet("ObtenerUsuarioTodos")]
        public IActionResult ObtenerUsuarioTodos()
        {
            var usuarios = _UsuarioDomain.ObtenerUsuarioTodos();
            return Ok(usuarios);
        }

        [HttpPost("InsertarUsuario")]
        public IActionResult InsertarUsuario(Usuario oUsuario)
        {
            var id = _UsuarioDomain.InsertarUsuario(oUsuario);
            return Ok(id);
        }

        [HttpPut("ActualizarUsuario")]
        public IActionResult ActualizarUsuario(Usuario oUsuario)
        {
            try
            {
                var id = _UsuarioDomain.ActualizarUsuario(oUsuario);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al actualizar el usuario: {ex.Message}");
            }
        }

        [HttpDelete("EliminarUsuario")]
        public IActionResult EliminarUsuario(int nId_Usuario)
        {
            try
            {
                var id = _UsuarioDomain.EliminarUsuario(nId_Usuario);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al eliminar el usuario: {ex.Message}");
            }
        }
    }
}
