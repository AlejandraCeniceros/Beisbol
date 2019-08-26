using System;
using System.Collections.Generic;
using System.Text;

namespace Beisbol
{
    class Equipo
    {
        public string NombreE { get; set; }
        public string Ciudad { get; set; }
        public string Entrenador { get; set; }
        public List<Jugador> Jugadores { get; set; }


        public Equipo()
        {
            NombreE = "sin nombre";
            Ciudad = "no registrada";
            Ciudad = "no registrada";
            Entrenador = "no registrada";

        }
        public Equipo(string nombreE)
        {
            NombreE = nombreE;
            Jugadores = new List<Jugador>();
        }

        public Equipo (string nombreE, string ciudad, string entrenador, string jugadores)
        {

        }

        public static implicit operator List<object>(Equipo v)
        {
            throw new NotImplementedException();
        }
    }
}
