using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase // Cambié AutorController a UsuarioController
    {
        private readonly UsuarioDomain _usuarioDomain; // Cambié AutorDomain a UsuarioDomain

        public UsuarioController(UsuarioDomain usuarioDomain) // Cambié el parámetro
        {
            _usuarioDomain = usuarioDomain;
        }

        [HttpGet("ObtenerUsuarioTodos")]
        public IActionResult ObtenerUsuarioTodos() // Cambié ObtenerAutorTodos a ObtenerUsuarioTodos
        {
            var usuarios = _usuarioDomain.ObtenerUsuarioTodos(); // Cambié Autors a usuarios
            return Ok(usuarios);
        }

        [HttpPost("InsertarUsuario")]
        public IActionResult InsertarUsuario(Usuario oUsuario) // Cambié InsertarAutor a InsertarUsuario
        {
            var id = _usuarioDomain.InsertarUsuario(oUsuario); // Cambié _AutorDomain a _usuarioDomain
            return Ok(id);
        }

        [HttpDelete("EliminarUsuarioTodos")] // Cambié EliminarAutorTodos a EliminarUsuarioTodos
        public IActionResult EliminarUsuarioTodos()
        {
            return Ok("Método no implementado");
        }

        [HttpPut("ActualizarUsuario")] 
        public IActionResult ActualizarUsuario(Usuario oUsuario) 
        {
            var id = _usuarioDomain.ActualizarUsuario(oUsuario);
            return Ok(id);
        }
    }
}
