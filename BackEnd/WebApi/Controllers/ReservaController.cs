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

        public ReservaController(ReservaDomain reservaDomain)
        {
            _ReservaDomain = reservaDomain;
        }

        [HttpGet("ObtenerReservaTodos")]
        public IActionResult ObtenerReservaTodos()
        {
            var reservas = _ReservaDomain.ObtenerReservaTodos();
            return Ok(reservas);
        }

        [HttpPost("InsertarReserva")]
        public IActionResult InsertarReserva(Reserva oReserva)
        {
            var id = _ReservaDomain.InsertarReserva(oReserva);
            return Ok(id);
        }

        [HttpPut("ActualizarReserva")]
        public IActionResult ActualizarReserva(Reserva oReserva)
        {
            try
            {
                var id = _ReservaDomain.ActualizarReserva(oReserva);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al actualizar la reserva: {ex.Message}");
            }
        }

        [HttpDelete("EliminarReserva")]
        public IActionResult EliminarReserva(int nId_Reserva)
        {
            try
            {
                var id = _ReservaDomain.EliminarReserva(nId_Reserva);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al eliminar la reserva: {ex.Message}");
            }
        }
    }
}
