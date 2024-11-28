using FrontEnd.Filter;
using FrontEnd.Models;
using FrontEnd.Servicio;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    [TypeFilter(typeof(TokenAuthorizationFilter))]
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _usuarioService;
        private string _token;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            _token = HttpContext.Request.Cookies["AuthToken"];

            if (string.IsNullOrEmpty(_token))
            {
                return Unauthorized("Token de autenticación requerido.");
            }

            var usuarios = await _usuarioService.GetUsuariosAsync(_token);
            return View(usuarios);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Usuario usuario)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];

            if (string.IsNullOrEmpty(_token))
            {
                return Unauthorized("Token de autenticación requerido.");
            }

            if (ModelState.IsValid)
            {
                var result = await _usuarioService.CreateUsuarioAsync(usuario, _token);
                if (result)
                {
                    return Ok("Usuario creado exitosamente.");
                }
            }

            return BadRequest("Datos inválidos o error al crear el usuario.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Usuario usuario)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];

            if (string.IsNullOrEmpty(_token))
            {
                return Unauthorized("Token de autenticación requerido.");
            }

            if (ModelState.IsValid)
            {
                var result = await _usuarioService.UpdateUsuarioAsync(usuario, _token);
                if (result)
                {
                    return Ok("Usuario actualizado exitosamente.");
                }
            }

            return BadRequest("Datos inválidos o error al actualizar el usuario.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];

            if (string.IsNullOrEmpty(_token))
            {
                return Unauthorized("Token de autenticación requerido.");
            }

            var result = await _usuarioService.DeleteUsuarioAsync(id, _token);
            if (result)
            {
                return Ok("Usuario eliminado exitosamente.");
            }

            return BadRequest("Error al eliminar el usuario.");
        }
    }
}
