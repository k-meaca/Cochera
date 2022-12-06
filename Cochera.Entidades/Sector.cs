using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades
{
    public class Sector
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int SectorId { get; private set; }

        public string Nombre { get; private set; }

        public int Capacidad { get; private set; }

        private List<Estacionamiento> estacionamientos;

        //------------CONSTRUCTOR------------//

        public Sector(int sectorId, string nombre, int capacidad)
        {
            SectorId = sectorId;
            Nombre = nombre;
            Capacidad = capacidad;

            estacionamientos = new List<Estacionamiento>();
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        //----PUBLICOS----//

        public void AgregarEstacionamiento(Estacionamiento estacionamiento)
        {
            estacionamientos.Add(estacionamiento);
        }

        public int LugaresDisponibles()
        {
            return Capacidad - estacionamientos.Count(e => e.Ocupado == true);
        }

        public Estacionamiento ObtenerEstacionamiento(int id)
        {
            return estacionamientos.Find(e => e.EstacionamientoId == id);
        }

        public List<Estacionamiento> ObtenerEstacionamientos()
        {
            return estacionamientos;
        }

        public List<Estacionamiento> ObtenerEsacionamientos(TipoDeVehiculo tipo)
        {
            return estacionamientos.FindAll(e => e.PuedeEstacionarVehiculo(tipo));
        }

    }
}
