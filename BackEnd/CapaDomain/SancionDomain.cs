using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class SancionDomain
    {
        private readonly SancionRepository _SancionRepository;

        public SancionDomain(SancionRepository SancionRepository)
        {
            _SancionRepository = SancionRepository;
        }

        public IEnumerable<Sancion> ObtenerSancionTodos()
        {
            try
            {
                return _SancionRepository.ObtenerSancionTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener Sanciones: " + ex.Message);
            }
        }

        public int InsertarSancion(Sancion oSancion)
        {
            try
            {
                return _SancionRepository.InsertarSancion(oSancion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Sancion: " + ex.Message);
            }
        }

        public int ActualizarSancion(Sancion oSancion)
        {
            try
            {
                return _SancionRepository.ActualizarSancion(oSancion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Sancion: " + ex.Message);
            }
        }
    }
}