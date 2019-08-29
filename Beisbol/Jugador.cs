using System;
using System.Collections.Generic;
using System.Text;

namespace Beisbol
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public Jugador() {

            Nombre = "no registrada";
            Numero = "no asignado";

        }

        public Jugador (string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
