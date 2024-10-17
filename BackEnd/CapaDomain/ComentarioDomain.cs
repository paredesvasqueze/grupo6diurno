using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class ComentarioDomain
    {
        private readonly ComentarioRepository _ComentarioRepository;

        public ComentarioDomain(ComentarioRepository comentarioRepository)
        {
            _ComentarioRepository = comentarioRepository;
        }

        public IEnumerable<Comentario> ObtenerComentarioTodos()
        {
            try
            {
                return _ComentarioRepository.ObtenerComentarioTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertarComentario(Comentario oComentario)
        {
            try
            {
                return _ComentarioRepository.InsertarComentario(oComentario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarComentario(Comentario oComentario)
        {
            try
            {
                return _ComentarioRepository.ActualizarComentario(oComentario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EliminarComentario(int nId_Comentario)
        {
            try
            {
                return _ComentarioRepository.EliminarComentario(nId_Comentario);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
