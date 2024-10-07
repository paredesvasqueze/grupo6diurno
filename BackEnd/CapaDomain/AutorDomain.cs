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
            catch (Exception ex)
            {
                throw new Exception("Error al obtener autores: " + ex.Message);
            }
        }

        public int InsertarAutor(Autor oAutor)
        {
            try
            {
                return _AutorRepository.InsertarAutor(oAutor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar autor: " + ex.Message);
            }
        }

        public int ActualizarAutor(Autor oAutor)
        {
            try
            {
                return _AutorRepository.ActualizarAutor(oAutor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar autor: " + ex.Message);
            }
        }
    }
}