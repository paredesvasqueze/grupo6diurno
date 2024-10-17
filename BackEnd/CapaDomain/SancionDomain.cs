using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class SancionDomain
    {
        private readonly SancionRepository _SancionRepository;

        public SancionDomain(SancionRepository sancionRepository)
        {
            _SancionRepository = sancionRepository;
        }

        public IEnumerable<Sancion> ObtenerSancionTodos()
        {
            try
            {
                return _SancionRepository.ObtenerSancionTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertarSancion(Sancion oSancion)
        {
            try
            {
                return _SancionRepository.InsertarSancion(oSancion);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarSancion(Sancion oSancion)
        {
            try
            {
                return _SancionRepository.ActualizarSancion(oSancion);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EliminarSancion(int nId_Sancion)
        {
            try
            {
                return _SancionRepository.EliminarSancion(nId_Sancion);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
