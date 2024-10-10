using System;
using System.Collections.Generic;
using System.Data;
using CapaEntidad;
using Dapper;

namespace CapaDatos
{
    public class SancionRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        public SancionRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        public IEnumerable<Sancion> ObtenerSancionTodos()
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_GET_Sancion_Todos";
                var param = new DynamicParameters();
                return SqlMapper.Query<Sancion>(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int InsertarSancion(Sancion oSancion)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Insert_Sancion";
                var param = new DynamicParameters();
                param.Add("@nMonto", oSancion.nMonto);
                param.Add("@cMotivo", oSancion.cMotivo);
                param.Add("@dFechaInicio", oSancion.dFechaInicio);
                param.Add("@dFechaFin", oSancion.dFechaFin);
                param.Add("@nIn_Usuario", oSancion.nIn_Usuario);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int ActualizarSancion(Sancion oSancion)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Actualizar_Sancion";
                var param = new DynamicParameters();
                param.Add("@nId_Sancion", oSancion.nId_Sancion);
                param.Add("@nMonto", oSancion.nMonto);
                param.Add("@cMotivo", oSancion.cMotivo);
                param.Add("@dFechaInicio", oSancion.dFechaInicio);
                param.Add("@dFechaFin", oSancion.dFechaFin);
                param.Add("@nIn_Usuario", oSancion.nIn_Usuario);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int BorrarSancion(int nId_Sancion)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Borrar_Sancion";
                var param = new DynamicParameters();
                param.Add("@nId_Sancion", nId_Sancion);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public Sancion ObtenerSancion(int nId_Sancion)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Obtener_Sancion";
                var param = new DynamicParameters();
                param.Add("@nId_Sancion", nId_Sancion);
                return SqlMapper.QuerySingleOrDefault<Sancion>(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}