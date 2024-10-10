using System;
using System.Collections.Generic;
using System.Data;
using CapaEntidad;
using Dapper;

namespace CapaDatos
{
    public class ComentarioRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        public ComentarioRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        public IEnumerable<Comentario> ObtenerComentarioTodos()
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_GET_Comentario_Todos";
                var param = new DynamicParameters();
                return SqlMapper.Query<Comentario>(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int InsertarComentario(Comentario oComentario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Insert_Comentario";
                var param = new DynamicParameters();
                param.Add("@cComentario", oComentario.cComentario);
                param.Add("@dFecha", oComentario.dFecha);
                param.Add("@nId_Usuario", oComentario.nId_Usuario);
                param.Add("@nId_Libro", oComentario.nId_Libro);
                param.Add("@nPuntuacion", oComentario.nPuntuacion);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int ActualizarComentario(Comentario oComentario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Actualizar_Comentario";
                var param = new DynamicParameters();
                param.Add("@nId_Comentario", oComentario.nId_Comentario);
                param.Add("@cComentario", oComentario.cComentario);
                param.Add("@dFecha", oComentario.dFecha);
                param.Add("@nId_Usuario", oComentario.nId_Usuario);
                param.Add("@nId_Libro", oComentario.nId_Libro);
                param.Add("@nPuntuacion", oComentario.nPuntuacion);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int BorrarComentario(int nId_Comentario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Borrar_Comentario";
                var param = new DynamicParameters();
                param.Add("@nId_Comentario", nId_Comentario);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public Comentario ObtenerComentario(int nId_Comentario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Obtener_Comentario";
                var param = new DynamicParameters();
                param.Add("@nId_Comentario", nId_Comentario);
                return SqlMapper.QuerySingleOrDefault<Comentario>(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
