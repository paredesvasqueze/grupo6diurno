using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class AutorDomain
    {
        private readonly AutorRepository _AutorRepository;

        public AutorDomain(AutorRepository autorRepository)
        {
            _AutorRepository = autorRepository;
        }

        public IEnumerable<Autor> ObtenerAutorTodos()
        {
            try
            {
                return _AutorRepository.ObtenerAutorTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertarAutor(Autor oAutor)
        {
            try
            {
                return _AutorRepository.InsertarAutor(oAutor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarAutor(Autor oAutor)
        {
            try
            {
                return _AutorRepository.ActualizarAutor(oAutor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EliminarAutor(int nId_Autor)
        {
            try
            {
                return _AutorRepository.EliminarAutor(nId_Autor);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
