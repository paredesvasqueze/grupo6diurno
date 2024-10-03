using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class AutorDomain
    {
        private readonly AutorRepository _AutorRepository;

        public AutorDomain(AutorRepository AutorRepository)
        {
           
                _AutorRepository = AutorRepository;     
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

        public int InsertAutor(Autor oAutor)
        {
            try
            {
                return _AutorRepository.InsertAutor(oAutor);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
