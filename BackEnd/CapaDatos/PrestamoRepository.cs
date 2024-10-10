using System;
using System.Collections.Generic;
using System.Data;
using CapaEntidad;
using Dapper;

namespace CapaDatos
{
    public class PrestamoRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        public PrestamoRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        public IEnumerable<Prestamo> ObtenerPrestamoTodos()
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_GET_Prestamo_Todos";
                var param = new DynamicParameters();
                return SqlMapper.Query<Prestamo>(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int InsertarPrestamo(Prestamo oPrestamo)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Insert_Prestamo";
                var param = new DynamicParameters();
                param.Add("@dFechaPrestamo", oPrestamo.dFechaPrestamo);
                param.Add("@cdFechaDevolucion", oPrestamo.dFechaDevolucion);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int ActualizarPrestamo(Prestamo oPrestamo)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Actualizar_Prestamo";
                var param = new DynamicParameters();
                param.Add("@dFechaPrestamo", oPrestamo.dFechaPrestamo);
                param.Add("@cdFechaDevolucion", oPrestamo.dFechaDevolucion);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int BorrarPrestamo(Prestamo oPrestamo)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Borrar_Prestamo";
                var param = new DynamicParameters();
                param.Add("@dFechaPrestamo", oPrestamo.dFechaPrestamo);
                param.Add("@cdFechaDevolucion", oPrestamo.dFechaDevolucion);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int ObtenerPrestamo(Prestamo oPrestamo)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Obtener_Prestamo";
                var param = new DynamicParameters();
                param.Add("@dFechaPrestamo", oPrestamo.dFechaPrestamo);
                param.Add("@cdFechaDevolucion", oPrestamo.dFechaDevolucion);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
