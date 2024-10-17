using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class ReservaDomain
    {
        private readonly ReservaRepository _ReservaRepository;

        public ReservaDomain(ReservaRepository reservaRepository)
        {
            _ReservaRepository = reservaRepository;
        }

        public IEnumerable<Reserva> ObtenerReservaTodos()
        {
            try
            {
                return _ReservaRepository.ObtenerReservaTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertarReserva(Reserva oReserva)
        {
            try
            {
                return _ReservaRepository.InsertarReserva(oReserva);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarReserva(Reserva oReserva)
        {
            try
            {
                return _ReservaRepository.ActualizarReserva(oReserva);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EliminarReserva(int nId_Reserva)
        {
            try
            {
                return _ReservaRepository.EliminarReserva(nId_Reserva);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
