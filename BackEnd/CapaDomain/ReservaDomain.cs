using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class ReservaDomain
    {
        private readonly ReservaRepository _ReservaRepository;

        public ReservaDomain(ReservaRepository ReservaRepository)
        {
            _ReservaRepository = ReservaRepository;
        }

        public IEnumerable<Reserva> ObtenerReservaTodos()
        {
            try
            {
                return _ReservaRepository.ObtenerReservaTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener Reservaes: " + ex.Message);
            }
        }

        public int InsertarReserva(Reserva oReserva)
        {
            try
            {
                return _ReservaRepository.InsertarReserva(oReserva);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Reserva: " + ex.Message);
            }
        }

        public int ActualizarReserva(Reserva oReserva)
        {
            try
            {
                return _ReservaRepository.ActualizarReserva(oReserva);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Reserva: " + ex.Message);
            }
        }
    }
}