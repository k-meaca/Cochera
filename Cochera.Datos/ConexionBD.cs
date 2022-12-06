using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Cochera.Datos
{
    public static class ConexionBD
    {

        //ATRIBUTOS

        private static readonly string conexionString;
        private static SqlConnection conexion;
        
        ///CONSTRUCTOR
        static ConexionBD()
        {
            try
            {
                conexionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                
            }
            catch (SqlException)
            {
                throw;
            }
        }

        //------------METODOS------------//

        //----PRIVADOS----//


        //----PUBLICOS----//

        public static SqlConnection AbrirConexion()
        {
            try
            {
                conexion = new SqlConnection(conexionString);
                conexion.Open();
                return conexion;
            }
            catch(SqlException)
            {
                throw;
            }
        }

    }
}
