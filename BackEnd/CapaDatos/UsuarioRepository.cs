using System;
using System.Collections.Generic;
using System.Data;
using CapaEntidad;
using Dapper;

namespace CapaDatos
{
<<<<<<< HEAD
    public class UsuarioRepository // Cambié AutorRepository a UsuarioRepository
=======
    public class UsuarioRepository
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
    {
        private readonly ConexionSingleton _conexionSingleton;

        public UsuarioRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

<<<<<<< HEAD
        public IEnumerable<Usuario> ObtenerUsuarioTodos() // Cambié ObtenerAutorTodos a ObtenerUsuarioTodos
=======
        public IEnumerable<Usuario> ObtenerUsuarioTodos()
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
<<<<<<< HEAD
                var query = "USP_GET_Usuario_Todos"; // Cambié el nombre del procedimiento
=======
                var query = "USP_GET_Usuario_Todos";
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
                var param = new DynamicParameters();
                return SqlMapper.Query<Usuario>(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

<<<<<<< HEAD
        public int InsertarUsuario(Usuario oUsuario) // Cambié InsertarAutor a InsertarUsuario
=======
        public int InsertarUsuario(Usuario oUsuario)
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
<<<<<<< HEAD
                var query = "USP_Insert_Usuario"; // Cambié el nombre del procedimiento
                var param = new DynamicParameters();
                param.Add("@cNombre", oUsuario.cNombre);
                param.Add("@cApellido", oUsuario.cApellido); // Agregué el apellido
                param.Add("@nTelefono", oUsuario.nTelefono); // Cambié dtelefono a nTelefono
                param.Add("@cDni", oUsuario.cDni); // Cambié cdni a cDni
=======
                var query = "USP_Insert_Usuario";
                var param = new DynamicParameters();
                param.Add("@cNombre", oUsuario.cNombre);
                param.Add("@cCorreo", oUsuario.cCorreo);
                param.Add("@cTelefono", oUsuario.cTelefono);
                param.Add("@cDocumentoIdentidad", oUsuario.cDocumentoIdentidad);
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

<<<<<<< HEAD
        public int ActualizarUsuario(Usuario oUsuario) // Cambié ActualizarAutor a ActualizarUsuario
=======
        public int ActualizarUsuario(Usuario oUsuario)
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
<<<<<<< HEAD
                var query = "USP_Actualizar_Usuario"; // Cambié el nombre del procedimiento
                var param = new DynamicParameters();
                param.Add("@nId_Usuario", oUsuario.nId_Usuario); // Agregué el ID del usuario
                param.Add("@cNombre", oUsuario.cNombre);
                param.Add("@cApellido", oUsuario.cApellido); // Agregué el apellido
                param.Add("@nTelefono", oUsuario.nTelefono); // Cambié dtelefono a nTelefono
                param.Add("@cDni", oUsuario.cDni); // Cambié cdni a cDni
=======
                var query = "USP_Actualizar_Usuario";
                var param = new DynamicParameters();
                param.Add("@nId_Usuario", oUsuario.nId_Usuario);
                param.Add("@cNombre", oUsuario.cNombre);
                param.Add("@cCorreo", oUsuario.cCorreo);
                param.Add("@cTelefono", oUsuario.cTelefono);
                param.Add("@cDocumentoIdentidad", oUsuario.cDocumentoIdentidad);
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

<<<<<<< HEAD
        // Otros métodos (BorrarUsuario, ObtenerUsuario) deben ser implementados de forma similar
=======
        public int BorrarUsuario(int nId_Usuario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Borrar_Usuario";
                var param = new DynamicParameters();
                param.Add("@nId_Usuario", nId_Usuario);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public Usuario ObtenerUsuario(int nId_Usuario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Obtener_Usuario";
                var param = new DynamicParameters();
                param.Add("@nId_Usuario", nId_Usuario);
                return SqlMapper.QuerySingleOrDefault<Usuario>(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
    }
}
