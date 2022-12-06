using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD:Estacionamiento.Entidades/Usuario.cs
namespace Estacionamiento.Entidades
=======
namespace Cochera.Entidades
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983:Cochera.Entidades/Usuario.cs
{
    public class Usuario
    {
        //ATRIBUTOS Y PROPIEDADES

        public int UsuarioId { get; private set; }

        private string Nick { get; set; }

        private string Password { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        //CONSTRUCTOR
        public Usuario(int usuarioId, string nick, string password)
        {
            UsuarioId = usuarioId;
            Nick = nick;
            Password = password;
        }

        //METODOS

<<<<<<< HEAD:Estacionamiento.Entidades/Usuario.cs
        public string NombreCompleto => Nombre + Apellido;

=======
        //TODO: Hacer este metodo.
        public string NombreCompleto()
        {
            string nombreCompleto = Nombre + " " + Apellido;
            return nombreCompleto;
        }
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983:Cochera.Entidades/Usuario.cs
    }
}
