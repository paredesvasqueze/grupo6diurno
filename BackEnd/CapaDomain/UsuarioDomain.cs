using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
<<<<<<< HEAD
    public class UsuarioDomain // Cambié AutorDomain a UsuarioDomain
    {
        private readonly UsuarioRepository _usuarioRepository; // Cambié AutorRepository a UsuarioRepository

        public UsuarioDomain(UsuarioRepository usuarioRepository) // Cambié el parámetro
        {
            _usuarioRepository = usuarioRepository;
        }

        public IEnumerable<Usuario> ObtenerUsuarioTodos() // Cambié ObtenerAutorTodos a ObtenerUsuarioTodos
        {
            try
            {
                return _usuarioRepository.ObtenerUsuarioTodos(); // Cambié _AutorRepository a _usuarioRepository
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener usuarios: " + ex.Message); // Cambié autores a usuarios
            }
        }

        public int InsertarUsuario(Usuario oUsuario) // Cambié InsertarAutor a InsertarUsuario
        {
            try
            {
                return _usuarioRepository.InsertarUsuario(oUsuario); // Cambié a _usuarioRepository
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar usuario: " + ex.Message); // Cambié autor a usuario
            }
        }

        public int ActualizarUsuario(Usuario oUsuario) // Cambié ActualizarAutor a ActualizarUsuario
        {
            try
            {
                return _usuarioRepository.ActualizarUsuario(oUsuario); // Cambié a _usuarioRepository
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar usuario: " + ex.Message); // Cambié autor a usuario
            }
        }
    }
}
=======
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
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
