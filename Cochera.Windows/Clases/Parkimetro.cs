using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cochera.Entidades;
using Cochera.Servicios;
using System.Drawing;

namespace Cochera.Windows.Clases
{

    public class Parkimetro
    {
        //------------ATRIBUTOS------------//

        private  List<Tarifa> tarifas;
        private  List<Tarifa> tarifasIngreso;
        private  ServicioTarifas servicioTarifas;

        //------------CONSTRUCTOR------------//

        public  Parkimetro()
        {
            servicioTarifas = new ServicioTarifas();
            tarifas = servicioTarifas.ObtenerTarifas();
            tarifasIngreso = new List<Tarifa>();
        }

        //------------METODOS------------//


        //----PRIVADOS----//

        //--AGREGAR TARIFAS--//

        #region
        private  void AgregarTarifaEstadia()
        {
            tarifasIngreso.Add(tarifas.Find(t => t.Tiempo == "Estadia"));
        }

        private  void AgregarTarifaHora(int cantidadHoras)
        {
            for(int i = 1; i <= cantidadHoras; i++)
            {
                tarifasIngreso.Add(tarifas.Find(t => t.Tiempo == "Hora"));
            }
        }

        private  void AgregarTarifaMediaEstadia()
        {
            tarifasIngreso.Add(tarifas.Find(t => t.Tiempo == "1/2 Estadia"));
        }

        private  void AgregarTarifaNoche()
        {
            tarifasIngreso.Add(tarifas.Find(t => t.Tiempo == "Noche"));
        }

        #endregion

        //--CALCULOS--//

        #region

        private  void CalcularTarifaCompuesta(ref double horasEstacionado, int horaIngreso, int horaSalida)
        {
            horasEstacionado -= 12;

            AgregarTarifaNoche();

            CalcularTarifaEnHoras(ref horasEstacionado);
        }
        private  void CalcularTarifaEnHoras(ref double horasEstacionado)
        {
            if(horasEstacionado <= 4)
            {
                CalcularPorHora(ref horasEstacionado);
            }
            else if(horasEstacionado <= 6)
            {
                AgregarTarifaMediaEstadia();
            }
            else
            {
                AgregarTarifaEstadia();
            }

        }

        private  void CalcularPorHora(ref double horasEstacionado)
        {
            int cantidadHoras = 0;

            if (horasEstacionado < 1.15f)
            {
                cantidadHoras = 1;
            }
            else if (horasEstacionado < 2.15f)
            {
                cantidadHoras = 2;
            }
            else if (horasEstacionado < 3.15f)
            {
                cantidadHoras = 3;
            }
            else
            {
                cantidadHoras = 4;
            }

            AgregarTarifaHora(cantidadHoras);
        }

        private  void CalcularTarifas(ref double horasEstacionado, int horaIngreso, int horaSalida)
        {
            if (horaIngreso >= 0 && horaSalida < 23)
            {
                CalcularTarifaEnHoras(ref horasEstacionado);
            }
            else if (horaIngreso == 20 && horaSalida == 8)
            {
                AgregarTarifaNoche();
            }
            else if (horaSalida >= 8 && horaIngreso < 20)
            {
                CalcularTarifaCompuesta(ref horasEstacionado, horaIngreso, horaSalida);
            }
        }

        #endregion

        //----PUBLICOS----//

        public Color ColorAbonado(Abonado abonado)
        {
            Color color;

            TimeSpan tiempo = abonado.FechaExpiracion - DateTime.Now;

            if(tiempo.TotalHours < 24)
            {
                color = Color.Salmon;
            }
            else if(tiempo.TotalHours < 48)
            {
                color = Color.SandyBrown;
            }
            else if(tiempo.TotalHours < 72)
            {
                color = Color.PaleGoldenrod;
            }
            else
            {
                color = Color.White;
            }

            return color;
            
        }

        public DateTime CalcularFechaExpiracion(Tarifa tarifa)
        {
            DateTime fechaExpiracion;

            switch (tarifa.Tiempo.ToUpper())
            {
                case "SEMANA":
                    fechaExpiracion = DateTime.Now.AddDays(7);
                    break;
                case "QUINCENA":
                    fechaExpiracion = DateTime.Now.AddDays(15);
                    break;
                case "MES":
                    fechaExpiracion = DateTime.Now.AddMonths(1);
                    break;
                default:
                    fechaExpiracion = new DateTime();
                    break;
            }

            return fechaExpiracion;
        }
        public  List<Tarifa> CalcularTarifa(Ingreso ingreso)
        {
            TimeSpan tiempoEstacionado = DateTime.Now - ingreso.ObtenerFechaIngreso();

            int dias = tiempoEstacionado.Days;

            int horaIngreso = ingreso.ObtenerFechaIngreso().Hour;
            double horasEstacionado = tiempoEstacionado.TotalHours;

            int horaSalida = DateTime.Now.Hour;

            while (dias > 0)
            {
                AgregarTarifaEstadia();
                AgregarTarifaNoche();
                dias--;
                horasEstacionado -= 24;
            }

            if(horasEstacionado > 0)
                CalcularTarifas(ref horasEstacionado, horaIngreso, horaSalida);


            return tarifasIngreso;
        }
    }
}
