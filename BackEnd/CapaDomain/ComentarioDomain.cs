using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class ComentarioDomain
    {
        private readonly ComentarioRepository _ComentarioRepository;

        public ComentarioDomain(ComentarioRepository ComentarioRepository)
        {
            _ComentarioRepository = ComentarioRepository;
        }

        public IEnumerable<Comentario> ObtenerComentarioTodos()
        {
            try
            {
                return _ComentarioRepository.ObtenerComentarioTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener Comentarioes: " + ex.Message);
            }
        }

        public int InsertarComentario(Comentario oComentario)
        {
            try
            {
                return _ComentarioRepository.InsertarComentario(oComentario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Comentario: " + ex.Message);
            }
        }

        public int ActualizarComentario(Comentario oComentario)
        {
            try
            {
                return _ComentarioRepository.ActualizarComentario(oComentario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Comentario: " + ex.Message);
            }
        }
    }
}