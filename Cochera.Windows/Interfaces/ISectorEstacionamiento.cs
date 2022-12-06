using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cochera.Entidades;

namespace Cochera.Windows.Interfaces
{
    public interface ISectorEstacionamiento
    {
        void AnularBotones();

        void ActivarBotones();

        void ActualizarLugares(TipoDeVehiculo vehiculo);
    }
}
