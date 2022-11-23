using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades.Interfaces
{
    public interface IIngreso
    {
        bool esAbonado();

        int ObtenerIngresoId();

        string ObtenerPatente();

        string ObtenerTipoVehiculo();
        int ObtenerTipoVehiculoId();

        DateTime ObtenerFechaIngreso();

        string ObtenerUbicacion();

        string ObtenerSector();

        string ObtenerImagenVehiculo();
    }
}
