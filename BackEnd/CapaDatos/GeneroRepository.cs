﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using Dapper;

namespace CapaDatos
{
    public class GeneroRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public GeneroRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de Generos
        public IEnumerable<Genero> ObtenerGeneroTodos()
        {
            var Generos = new List<Genero>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<Genero> lstFound = new List<Genero>();
                var query = "USP_Select_Genero";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<Genero>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;              
                
            }
        }

        public int InsertarGenero(Genero oGenero)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                
                var query = "USP_Insert_Genero";
                var param = new DynamicParameters();
                param.Add("@nId_Genero", oGenero.nId_Genero);
                param.Add("@cNombreGenero", oGenero.cNombreGenero);          
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);                
            }

        }

        public int ActualizarGenero(Genero oGenero)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Actualizar_Genero";
                var param = new DynamicParameters();
                param.Add("@nId_Genero", oGenero.nId_Genero);
                param.Add("@cNombreGenero", oGenero.cNombreGenero);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public int EliminarGenero(int nId_Genero)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Delete_Genero";
                var param = new DynamicParameters();
                param.Add("@nId_Genero", nId_Genero);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }


    }
}
