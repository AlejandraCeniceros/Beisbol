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
            Entrenador = "no registrada";
            Jugadores = new List<Jugador>();


        }
        public Equipo(string nombreE)
        {
            NombreE = nombreE;
            Ciudad = "no registrada";
            Entrenador = "no registrada";
            Jugadores = new List<Jugador>();

        }

        public Equipo (string nombreE, string ciudad, string entrenador, string jugadores)
        {
            NombreE = nombreE;
            Ciudad = "No asignado";
            Entrenador = "No asignado";
            Jugadores = new List<Jugador>();
        }

       
    }
}
