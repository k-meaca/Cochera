﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Estacionamiento.Entidades;

namespace Estacionamiento.Datos.Repositorios
{
    public class RepositorioTarifas
    {
        //------------ATRIBUTOS------------//

        private SqlConnection conexion;

        //------------CONSTRUCTOR------------//

        public RepositorioTarifas(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        //------------METODOS------------//

        //----PRIVADOS----//


        //----PUBLICOS----//
        public List<Tarifa> obtenerTarifas()
        {
            List<Tarifa> tarifas = new List<Tarifa>();
            try
            {
                string query = "SELECT * FROM Tarifas;";

                using (SqlCommand comando = new SqlCommand(query))
                {
                    comando.Connection = conexion;

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            int tarifaId = lector.GetInt32(0);
                            string tiempo = lector.GetString(1);
                            Tarifa tarifa = new Tarifa(tarifaId, tiempo);
                            tarifas.Add(tarifa);
                        }

                    }
                }
            }
            catch(SqlException)
            {
                throw;
            }

            return tarifas;
        }
    }
}
