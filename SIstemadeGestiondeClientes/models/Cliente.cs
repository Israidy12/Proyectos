﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIstemadeGestiondeClientes
{
    internal class Cliente
    {

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string TarjetadeCredito { get; set; }

        public string NombreCompleto
        {

            get { return Nombre + " " + Apellido; }
               
        }



            public override string ToString()
        {
            return Nombre + " " + Apellido;


        }
    }
}

