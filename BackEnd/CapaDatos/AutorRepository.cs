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
    public class AutorRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public AutorRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de Autors
        public IEnumerable<Autor> ObtenerAutorTodos()
        {
            var Autor = new List<Autor>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<Autor> lstFound = new List<Autor>();
                var query = "USP_GET_Autor_Todos";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<Autor>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;              
                
            }
        }

        public int InsertAutor(Autor oAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                
                var query = "USP_Insert_Autor";
                var param = new DynamicParameters();
                param.Add("@cNombre", oAutor.cNombre);
                param.Add("@cApellido", oAutor.cNacionalidad);
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
                param.Add("@cNombre", oAutor.cNombre);
                param.Add("@cApellido", oAutor.cNacionalidad);
                param.Add("@dFechaNacimiento", oAutor.dFechaNacimiento);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

        public int BorrarAutor(Autor oAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Borrar_Autor";
                var param = new DynamicParameters();
                param.Add("@cNombre", oAutor.cNombre);
                param.Add("@cApellido", oAutor.cNacionalidad);
                param.Add("@dFechaNacimiento", oAutor.dFechaNacimiento);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

        public int ObtenerAutor(Autor oAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Obtener_Autor";
                var param = new DynamicParameters();
                param.Add("@cNombre", oAutor.cNombre);
                param.Add("@cApellido", oAutor.cNacionalidad);
                param.Add("@dFechaNacimiento", oAutor.dFechaNacimiento);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }
    }
}
