using System;
using System.Collections.Generic;
using System.Data;
using CapaEntidad;
using Dapper;

namespace CapaDatos
{
    public class UsuarioRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        public UsuarioRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        public IEnumerable<Usuario> ObtenerUsuarioTodos()
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_GET_Usuario_Todos";
                var param = new DynamicParameters();
                return SqlMapper.Query<Usuario>(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int InsertarUsuario(Usuario oUsuario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Insert_Usuario";
                var param = new DynamicParameters();
                param.Add("@cNombre", oUsuario.cNombre);
                param.Add("@cCorreo", oUsuario.cCorreo);
                param.Add("@cTelefono", oUsuario.cTelefono);
                param.Add("@cDocumentoIdentidad", oUsuario.cDocumentoIdentidad);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int ActualizarUsuario(Usuario oUsuario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Actualizar_Usuario";
                var param = new DynamicParameters();
                param.Add("@nId_Usuario", oUsuario.nId_Usuario);
                param.Add("@cNombre", oUsuario.cNombre);
                param.Add("@cCorreo", oUsuario.cCorreo);
                param.Add("@cTelefono", oUsuario.cTelefono);
                param.Add("@cDocumentoIdentidad", oUsuario.cDocumentoIdentidad);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

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
    }
}
