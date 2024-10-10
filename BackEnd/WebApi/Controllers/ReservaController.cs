using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly ReservaDomain _ReservaDomain;

        public ReservaController(ReservaDomain ReservaDomain)
        {
            _ReservaDomain = ReservaDomain;
        }

        [HttpGet("ObtenerReservaTodos")]
        public IActionResult ObtenerReservaTodos()
        {
            var Reservas = _ReservaDomain.ObtenerReservaTodos();
            return Ok(Reservas);
        }

        [HttpPost("InsertarReserva")]
        public IActionResult InsertarReserva(Reserva oReserva)
        {
            var id = _ReservaDomain.InsertarReserva(oReserva);
            return Ok(id);
        }

        [HttpDelete("EliminarReservaTodos")]
        public IActionResult EliminarReservaTodos()
        {
            // Implementa la lógica de eliminación si es necesario
            return Ok("Método no implementado");
        }

        [HttpPut("ActualizarReserva")]
        public IActionResult ActualizarReserva(Reserva oReserva)
        {
            var id = _ReservaDomain.ActualizarReserva(oReserva); // Cambiado a `ActualizarReserva`
            return Ok(id);
        }
    }
}
