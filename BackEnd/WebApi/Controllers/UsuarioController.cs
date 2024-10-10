using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
<<<<<<< HEAD
    public class UsuarioController : ControllerBase // Cambi� AutorController a UsuarioController
    {
        private readonly UsuarioDomain _usuarioDomain; // Cambi� AutorDomain a UsuarioDomain

        public UsuarioController(UsuarioDomain usuarioDomain) // Cambi� el par�metro
        {
            _usuarioDomain = usuarioDomain;
        }

        [HttpGet("ObtenerUsuarioTodos")]
        public IActionResult ObtenerUsuarioTodos() // Cambi� ObtenerAutorTodos a ObtenerUsuarioTodos
        {
            var usuarios = _usuarioDomain.ObtenerUsuarioTodos(); // Cambi� Autors a usuarios
            return Ok(usuarios);
        }

        [HttpPost("InsertarUsuario")]
        public IActionResult InsertarUsuario(Usuario oUsuario) // Cambi� InsertarAutor a InsertarUsuario
        {
            var id = _usuarioDomain.InsertarUsuario(oUsuario); // Cambi� _AutorDomain a _usuarioDomain
            return Ok(id);
        }

        [HttpDelete("EliminarUsuarioTodos")] // Cambi� EliminarAutorTodos a EliminarUsuarioTodos
        public IActionResult EliminarUsuarioTodos()
        {
            return Ok("M�todo no implementado");
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
            // Implementa la l�gica de eliminaci�n si es necesario
            return Ok("M�todo no implementado");
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
