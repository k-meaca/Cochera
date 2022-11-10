using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades.Excepciones
{
    public class UsuarioInvalidoExcepcion : Exception
    {
        public UsuarioInvalidoExcepcion(string mensaje) : base(mensaje) { }
    }
}
