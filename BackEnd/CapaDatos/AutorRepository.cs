using System;
using System.Collections.Generic;
using System.Data;
using CapaEntidad;
using Dapper;

namespace CapaDatos
{
    public class AutorRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        public AutorRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        public IEnumerable<Autor> ObtenerAutorTodos()
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_GET_Autor_Todos";
                var param = new DynamicParameters();
                return SqlMapper.Query<Autor>(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int InsertarAutor(Autor oAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Insert_Autor";
                var param = new DynamicParameters();
                param.Add("@cNombre", oAutor.cNombre);
                param.Add("@cNacionalidad", oAutor.cNacionalidad);
                param.Add("@dFechaNacimiento", oAutor.dFechaNacimiento);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int ActualizarAutor(Autor oAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Actualizar_Autor";
                var param = new DynamicParameters();
                param.Add("@cNombre", oAutor.cNombre);
                param.Add("@cNacionalidad", oAutor.cNacionalidad); // Corregido
                param.Add("@dFechaNacimiento", oAutor.dFechaNacimiento);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int BorrarAutor(Autor oAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Borrar_Autor";
                var param = new DynamicParameters();
                param.Add("@cNombre", oAutor.cNombre);
                param.Add("@cNacionalidad", oAutor.cNacionalidad); // Corregido
                param.Add("@dFechaNacimiento", oAutor.dFechaNacimiento);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }


        public int ObtenerAutor(Autor oAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Obtener_Autor";
                var param = new DynamicParameters();
                param.Add("@cNombre", oAutor.cNombre);
                param.Add("@cNacionalidad", oAutor.cNacionalidad); // Corregido
                param.Add("@dFechaNacimiento", oAutor.dFechaNacimiento);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
