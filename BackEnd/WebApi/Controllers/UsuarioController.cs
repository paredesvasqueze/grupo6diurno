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

        public UsuarioController(UsuarioDomain UsuarioDomain)
        {
            _UsuarioDomain = UsuarioDomain;
        }

        [HttpGet("ObtenerUsuarioTodos")]
        public IActionResult ObtenerUsuarioTodos()
        {
            var Usuarios = _UsuarioDomain.ObtenerUsuarioTodos();
            return Ok(Usuarios);
        }

        [HttpPost("InsertarUsuario")]
        public IActionResult InsertarUsuario(Usuario oUsuario)
        {
            var id = _UsuarioDomain.InsertarUsuario(oUsuario);
            return Ok(id);
        }

        [HttpDelete("EliminarUsuarioTodos")]
        public IActionResult EliminarUsuarioTodos()
        {
            // Implementa la lógica de eliminación si es necesario
            return Ok("Método no implementado");
        }

        [HttpPut("ActualizarUsuario")]
        public IActionResult ActualizarUsuario(Usuario oUsuario)
        {
            var id = _UsuarioDomain.ActualizarUsuario(oUsuario); // Cambiado a `ActualizarUsuario`

            return Ok(id);
        }
    }
}
