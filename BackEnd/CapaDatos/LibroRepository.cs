using System;
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
    public class LibroRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public LibroRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de Libros
        public IEnumerable<Libro> ObtenerLibroTodos()
        {
            var Libros = new List<Libro>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<Libro> lstFound = new List<Libro>();
                var query = "USP_GET_Libro_Todos";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<Libro>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;              
                
            }
        }

       // public List<Libro> ObtenerTodosLosLibros()
        //{
          //  using (var connection = _conexionSingleton.GetConnection())
            //{
              //  connection.Open();

                //var query = "USP_GET_Libro_Todos";
                //return SqlMapper.Query<Libro>(connection, query, commandType: CommandType.StoredProcedure).ToList();
          //  }
       // }


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

                return SqlMapper.Execute(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public void EliminarLibro(int nId_Libro)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Eliminar_Libro";
                var param = new DynamicParameters();
                param.Add("@nId_Libro", nId_Libro);

                SqlMapper.Execute(connection, query, param, commandType: CommandType.StoredProcedure);
            }
        }


    }
}
