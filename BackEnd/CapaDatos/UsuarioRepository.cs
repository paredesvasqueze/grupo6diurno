using System;
using System.Collections.Generic;
using System.Data;
using CapaEntidad;
using Dapper;

namespace CapaDatos
{
    public class UsuarioRepository // Cambié AutorRepository a UsuarioRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        public UsuarioRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        public IEnumerable<Usuario> ObtenerUsuarioTodos() // Cambié ObtenerAutorTodos a ObtenerUsuarioTodos
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_GET_Usuario_Todos"; // Cambié el nombre del procedimiento
                var param = new DynamicParameters();
                return SqlMapper.Query<Usuario>(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int InsertarUsuario(Usuario oUsuario) // Cambié InsertarAutor a InsertarUsuario
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Insert_Usuario"; // Cambié el nombre del procedimiento
                var param = new DynamicParameters();
                param.Add("@cNombre", oUsuario.cNombre);
                param.Add("@cApellido", oUsuario.cApellido); // Agregué el apellido
                param.Add("@nTelefono", oUsuario.nTelefono); // Cambié dtelefono a nTelefono
                param.Add("@cDni", oUsuario.cDni); // Cambié cdni a cDni
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int ActualizarUsuario(Usuario oUsuario) // Cambié ActualizarAutor a ActualizarUsuario
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Actualizar_Usuario"; // Cambié el nombre del procedimiento
                var param = new DynamicParameters();
                param.Add("@nId_Usuario", oUsuario.nId_Usuario); // Agregué el ID del usuario
                param.Add("@cNombre", oUsuario.cNombre);
                param.Add("@cApellido", oUsuario.cApellido); // Agregué el apellido
                param.Add("@nTelefono", oUsuario.nTelefono); // Cambié dtelefono a nTelefono
                param.Add("@cDni", oUsuario.cDni); // Cambié cdni a cDni
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        // Otros métodos (BorrarUsuario, ObtenerUsuario) deben ser implementados de forma similar
    }
}
