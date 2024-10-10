﻿using System;
using System.Collections.Generic;
using System.Data;
using CapaEntidad;
using Dapper;

namespace CapaDatos
{
    public class ReservaRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        public ReservaRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        public IEnumerable<Reserva> ObtenerReservaTodos()
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_GET_Reserva_Todos";
                var param = new DynamicParameters();
                return SqlMapper.Query<Reserva>(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int InsertarReserva(Reserva oReserva)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Insert_Reserva";
                var param = new DynamicParameters();
                param.Add("@dFechaReserva", oReserva.dFechaReserva);
                param.Add("@nId_Usuario", oReserva.nId_Usuario);
                param.Add("@nId_Libro", oReserva.nId_Libro);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int ActualizarReserva(Reserva oReserva)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Actualizar_Reserva";
                var param = new DynamicParameters();
                param.Add("@nId_Reserva", oReserva.nId_Reserva);
                param.Add("@dFechaReserva", oReserva.dFechaReserva);
                param.Add("@nId_Usuario", oReserva.nId_Usuario);
                param.Add("@nId_Libro", oReserva.nId_Libro);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int BorrarReserva(int nId_Reserva)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Borrar_Reserva";
                var param = new DynamicParameters();
                param.Add("@nId_Reserva", nId_Reserva);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public Reserva ObtenerReserva(int nId_Reserva)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                var query = "USP_Obtener_Reserva";
                var param = new DynamicParameters();
                param.Add("@nId_Reserva", nId_Reserva);
                return SqlMapper.QuerySingleOrDefault<Reserva>(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
