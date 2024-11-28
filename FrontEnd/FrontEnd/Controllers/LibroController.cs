using FrontEnd.Filter;
using FrontEnd.Models;
using FrontEnd.Servicio;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FrontEnd.Controllers
{
    [TypeFilter(typeof(TokenAuthorizationFilter))]
    [ApiController]
    [Route("[controller]")]
    public class LibroController : Controller
    {
        private readonly LibroService _libroService;
        private readonly AutorService _AutorService;
        private readonly GeneroService _GeneroService;
        private string _token;

        public LibroController(LibroService libroService, AutorService autorService, GeneroService generoService)
        {
            _libroService = libroService;
            _AutorService = autorService;
            _GeneroService = generoService;
        }

        private bool TryGetAuthToken(out string token)
        {
            token = HttpContext.Request.Cookies["AuthToken"];
            return !string.IsNullOrEmpty(token);
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (!TryGetAuthToken(out _token))
            {
                return Unauthorized("El token de autenticación es requerido.");
            }

            try
            {
                var libros = await _libroService.GetLibrosAsync(_token);
                var autores = await _AutorService.GetAutorsAsync(_token);
                var generos = await _GeneroService.GetGenerosAsync(_token);

                ViewBag.Autores = autores;
                ViewBag.Generos = generos;
                if (libros == null || !libros.Any())
                {
                    ViewBag.Message = "No hay libros disponibles.";
                    return View(Enumerable.Empty<Libro>()); // Retorna una lista vacía a la vista
                }
               

                return View(libros);
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                return StatusCode(500, $"Error al obtener los libros: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Libro libro)
        {
            if (!TryGetAuthToken(out _token))
            {
                return Unauthorized("El token de autenticación es requerido.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Modelo inválido.");
            }

            try
            {
                var result = await _libroService.CreateLibroAsync(libro, _token);
                if (result)
                {
                    return Ok("Libro creado exitosamente.");
                }
                return BadRequest("Error al crear el libro.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al crear el libro: {ex.Message}");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Libro libro)
        {
            if (!TryGetAuthToken(out _token))
            {
                return Unauthorized("El token de autenticación es requerido.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Modelo inválido.");
            }

            try
            {
                var result = await _libroService.UpdateLibroAsync(libro, _token);
                if (result)
                {
                    return Ok("Libro actualizado exitosamente.");
                }
                return BadRequest("Error al actualizar el libro.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar el libro: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!TryGetAuthToken(out _token))
            {
                return Unauthorized("El token de autenticación es requerido.");
            }

            try
            {
                var result = await _libroService.DeleteLibroAsync(id, _token);
                if (result)
                {
                    return Ok("Libro eliminado exitosamente.");
                }
                return BadRequest("Error al eliminar el libro.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al eliminar el libro: {ex.Message}");
            }
        }
    }
}
