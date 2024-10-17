using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using CapaEntidad;

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
                return SqlMapper.Query<Sancion>(connection, query, commandType: CommandType.StoredProcedure);
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
                param.Add("@nId_Usuario", oSancion.nId_Usuario);
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
                param.Add("@nId_Usuario", oSancion.nId_Usuario);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int EliminarSancion(int nId_Sancion)
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
    }
}
