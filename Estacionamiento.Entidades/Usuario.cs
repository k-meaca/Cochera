﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entidades
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

        public string NombreCompleto => Nombre + Apellido;

    }
}