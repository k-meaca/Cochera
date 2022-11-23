using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades.Interfaces
{
    public interface IContable
    {
        string Descripcion();

        string Vehiculo();

        string Patente();

        DateTime FechaMovimiento();

        string MedioDePago();

        decimal Importe();

    }
}
