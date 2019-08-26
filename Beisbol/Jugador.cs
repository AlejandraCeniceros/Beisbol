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
            Numero = "no registrada";

        }

        public Jugador (string numero)
        {
            Nombre = nombre;
            Numero = numero;

        }
    }
}
