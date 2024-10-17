using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using CapaEntidad;

namespace CapaDatos
{
    public class LibroRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        public LibroRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        public IEnumerable<Libro> ObtenerLibroTodos()
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_GET_Libro_Todos";
                return SqlMapper.Query<Libro>(connection, query, commandType: CommandType.StoredProcedure);
            }
        }

        public int InsertarLibro(Libro oLibro)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Insert_Libro";
                var param = new DynamicParameters();
                param.Add("@cTitulo", oLibro.cTitulo);
                param.Add("@dAnio", oLibro.dAnio);
                param.Add("@nId_Autor", oLibro.nId_Autor);
                param.Add("@nId_Genero", oLibro.nId_Genero);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int ActualizarLibro(Libro oLibro)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Actualizar_Libro";
                var param = new DynamicParameters();
                param.Add("@nId_Libro", oLibro.nId_Libro);
                param.Add("@cTitulo", oLibro.cTitulo);
                param.Add("@dAnio", oLibro.dAnio);
                param.Add("@nId_Autor", oLibro.nId_Autor);
                param.Add("@nId_Genero", oLibro.nId_Genero);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int EliminarLibro(int nId_Libro)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Borrar_Libro";
                var param = new DynamicParameters();
                param.Add("@nId_Libro", nId_Libro);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
