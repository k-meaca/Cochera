using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cochera.Datos.Repositorios
{
    public abstract class Repositorio
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//
        protected SqlConnection conexion;
        protected SqlTransaction transaccion;

        //------------CONSTRUCTOR------------//

        public Repositorio(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public Repositorio(SqlConnection conexion, SqlTransaction transaccion) : this(conexion)
        {
            this.transaccion = transaccion;
        }
    }
}
