using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{

    public class UsuarioDomain
    {
        private readonly UsuarioRepository _UsuarioRepository;

        public UsuarioDomain(UsuarioRepository UsuarioRepository)
        {
            _UsuarioRepository = UsuarioRepository;
        }

        public IEnumerable<Usuario> ObtenerUsuarioTodos()
        {
            try
            {
                return _UsuarioRepository.ObtenerUsuarioTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener Usuarioes: " + ex.Message);
            }
        }

        public int InsertarUsuario(Usuario oUsuario)
        {
            try
            {
                return _UsuarioRepository.InsertarUsuario(oUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Usuario: " + ex.Message);
            }
        }

        public int ActualizarUsuario(Usuario oUsuario)
        {
            try
            {
                return _UsuarioRepository.ActualizarUsuario(oUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Usuario: " + ex.Message);
            }
        }
    }
}

