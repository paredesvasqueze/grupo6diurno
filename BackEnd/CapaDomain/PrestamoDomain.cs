using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class PrestamoDomain
    {
        private readonly PrestamoRepository _PrestamoRepository;

        public PrestamoDomain(PrestamoRepository prestamoRepository)
        {
            _PrestamoRepository = prestamoRepository;
        }

        public IEnumerable<Prestamo> ObtenerPrestamoTodos()
        {
            try
            {
                return _PrestamoRepository.ObtenerPrestamoTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertarPrestamo(Prestamo oPrestamo)
        {
            try
            {
                return _PrestamoRepository.InsertarPrestamo(oPrestamo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarPrestamo(Prestamo oPrestamo)
        {
            try
            {
                return _PrestamoRepository.ActualizarPrestamo(oPrestamo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EliminarPrestamo(int nId_Prestamo)
        {
            try
            {
                return _PrestamoRepository.EliminarPrestamo(nId_Prestamo);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
