using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using CapaEntidad;

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
                return SqlMapper.Query<Prestamo>(connection, query, commandType: CommandType.StoredProcedure);
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
                param.Add("@dFechaDevolucion", oPrestamo.dFechaDevolucion);
                param.Add("@nId_Usuario", oPrestamo.nId_Usuario);
                param.Add("@nId_Libro", oPrestamo.nId_Libro);
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
                param.Add("@nId_Prestamo", oPrestamo.nId_Prestamo);
                param.Add("@dFechaPrestamo", oPrestamo.dFechaPrestamo);
                param.Add("@dFechaDevolucion", oPrestamo.dFechaDevolucion);
                param.Add("@nId_Usuario", oPrestamo.nId_Usuario);
                param.Add("@nId_Libro", oPrestamo.nId_Libro);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int EliminarPrestamo(int nId_Prestamo)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Borrar_Prestamo";
                var param = new DynamicParameters();
                param.Add("@nId_Prestamo", nId_Prestamo);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
