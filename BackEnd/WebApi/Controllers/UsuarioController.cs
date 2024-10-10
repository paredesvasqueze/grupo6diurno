using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
<<<<<<< HEAD
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
=======
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
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
            return Ok(id);
        }
    }
}
