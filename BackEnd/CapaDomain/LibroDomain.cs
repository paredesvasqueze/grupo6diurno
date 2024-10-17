using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class LibroDomain
    {
        private readonly LibroRepository _LibroRepository;

        public LibroDomain(LibroRepository libroRepository)
        {
            _LibroRepository = libroRepository;
        }

        public IEnumerable<Libro> ObtenerLibroTodos()
        {
            try
            {
                return _LibroRepository.ObtenerLibroTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertarLibro(Libro oLibro)
        {
            try
            {
                return _LibroRepository.InsertarLibro(oLibro);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarLibro(Libro oLibro)
        {
            try
            {
                return _LibroRepository.ActualizarLibro(oLibro);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EliminarLibro(int nId_Libro)
        {
            try
            {
                return _LibroRepository.EliminarLibro(nId_Libro);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
