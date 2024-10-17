using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using CapaEntidad;

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
                return SqlMapper.Query<Autor>(connection, query, commandType: CommandType.StoredProcedure);
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
                param.Add("@nId_Autor", oAutor.nId_Autor);
                param.Add("@cNombre", oAutor.cNombre);
                param.Add("@cNacionalidad", oAutor.cNacionalidad);
                param.Add("@dFechaNacimiento", oAutor.dFechaNacimiento);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int EliminarAutor(int nId_Autor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Borrar_Autor";
                var param = new DynamicParameters();
                param.Add("@nId_Autor", nId_Autor);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
