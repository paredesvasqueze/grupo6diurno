using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class PrestamoDomain
    {
        private readonly PrestamoRepository _PrestamoRepository;

        public PrestamoDomain(PrestamoRepository PrestamoRepository)
        {
            _PrestamoRepository = PrestamoRepository;
        }

        public IEnumerable<Prestamo> ObtenerPrestamoTodos()
        {
            try
            {
                return _PrestamoRepository.ObtenerPrestamoTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener Prestamoes: " + ex.Message);
            }
        }

        public int InsertarPrestamo(Prestamo oPrestamo)
        {
            try
            {
                return _PrestamoRepository.InsertarPrestamo(oPrestamo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Prestamo: " + ex.Message);
            }
        }

        public int ActualizarPrestamo(Prestamo oPrestamo)
        {
            try
            {
                return _PrestamoRepository.ActualizarPrestamo(oPrestamo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Prestamo: " + ex.Message);
            }
        }
    }
}