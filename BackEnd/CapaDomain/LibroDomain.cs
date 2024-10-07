using CapaEntidad;
using CapaDatos;
using System.Collections.Generic;

namespace CapaDomain
{
    public class LibroDomain
    {
        private readonly LibroRepository _LibroRepository;

        public LibroDomain(LibroRepository LibroRepository)
        {
           
                _LibroRepository = LibroRepository;     
        }

        public List<Libro> ObtenerTodosLosLibros( )
        {
            try
            {
                return (List< Libro >)_LibroRepository.ObtenerLibroTodos();
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

        public void EliminarLibro(int nId_Libro)
        {
            try
            {
                _LibroRepository.EliminarLibro(nId_Libro);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
