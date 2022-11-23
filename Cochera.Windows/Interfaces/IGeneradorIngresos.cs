using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cochera.Entidades;
using Cochera.Entidades.Interfaces;

namespace Cochera.Windows.Interfaces
{
    public interface IGeneradorIngresos : ISectorEstacionamiento
    {
        void EstacionamientoOcupado(TipoDeVehiculo tipo, IIngreso ingreso);

        string ObtenerUbicacion();

        bool PuedeEstacionarVehiculo(TipoDeVehiculo tipo);
    }
}
