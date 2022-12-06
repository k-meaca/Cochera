using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Windows.Interfaces
{
    public interface IGeneradorSalidas : ISectorEstacionamiento
    {
        void DesocuparEstacionamiento();
    }
}
