using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades
{
    public class Estacionamiento
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int EstacionamientoId { get; private set; }

        public string Ubicacion { get; private set; }

        private Sector sector;

        public bool Ocupado { get; private set; }

        List<TipoDeVehiculo> vehiculosAdmitidos;

        //------------CONSTRUCTOR------------//

        public Estacionamiento(int id, string ubicacion, Sector sector, bool ocupado)
        {
            EstacionamientoId = id;
            Ubicacion = ubicacion;
            this.sector = sector;
            Ocupado = ocupado;

            vehiculosAdmitidos = new List<TipoDeVehiculo>();
        }

        //------------METODOS------------//

        //----PRIVADOS----//


        //----PUBLICOS----//
        public void EstacionarVehiculo(TipoDeVehiculo tipo)
        {
            if (PuedeEstacionarVehiculo(tipo) && !Ocupado)
            {
                Ocupado = true;
            }
        }

        public string ObtenerSector()
        {
            return sector.Nombre;
        }

        public int ObtenerSectorId()
        {
            return sector.SectorId;
        }

        public void PermitirVehiculo(TipoDeVehiculo tipo)
        {
            vehiculosAdmitidos.Add(tipo);
        }
        public bool PuedeEstacionarVehiculo(TipoDeVehiculo tipo)
        {
            return vehiculosAdmitidos.Any(v => v.TipoId == tipo.TipoId);
        }

        public bool PuedeEstacionarVehiculo(int tipoId)
        {
            return vehiculosAdmitidos.Any(v => v.TipoId == tipoId);
        }

        public void SacarVehiculo()
        {
            Ocupado = false;
        }

    }
}
