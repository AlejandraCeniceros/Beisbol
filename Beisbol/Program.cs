using System;
using System.Collections.Generic;

namespace Beisbol
{
    class Program
    {
        static void Main(string[] args)
        {
       

            List<Equipo> equipos = new List<Equipo>();

            Equipo elnombre = new Equipo("elnombredelequipo");
            elnombre.Entrenador = "juan";
            elnombre.Ciudad = "navojoa";
            elnombre.Jugadores.Add(new Jugador("jugador 1", 54));
            elnombre.Jugadores.Add(new Jugador("jugador 2", 1));
            elnombre.Jugadores.Add(new Jugador("jugador 3", 8));
            elnombre.Jugadores.Add(new Jugador("jugador 4", 2));
            elnombre.Jugadores.Add(new Jugador("jugador 5", 9));
            elnombre.Jugadores.Add(new Jugador("jugador 6", 22));
            elnombre.Jugadores.Add(new Jugador("jugador 7", 14);
            elnombre.Jugadores.Add(new Jugador("jugador 8", 11)); 
            elnombre.Jugadores.Add(new Jugador("jugador 9", 5));

            Equipo otro = new Equipo("otro");
            otro.Entrenador = "Ana";
            otro.Ciudad = "Cajeme";
            otro.Jugadores.Add(new Jugador("Jugador 10", 6));
            otro.Jugadores.Add(new Jugador("Jugador 10", 12));
            otro.Jugadores.Add(new Jugador("Jugador 10", 4));
            otro.Jugadores.Add(new Jugador("Jugador 10", 7));
            otro.Jugadores.Add(new Jugador("Jugador 10", 10));
            otro.Jugadores.Add(new Jugador("Jugador 10", 12));
            otro.Jugadores.Add(new Jugador("Jugador 10", 16));
            otro.Jugadores.Add(new Jugador("Jugador 10", 21));
            otro.Jugadores.Add(new Jugador("Jugador 10", 18));

            equipos.Add(elnombre);
            equipos.Add(otro);

            foreach(Equipo equipo in equipos)
            {
                Console.WriteLine("*" + equipo.NombreE + "de" equipo.Ciudad);

                foreach(Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("*" + jugador.Nombre + jugador.Numero);
                }
            }
        }
    }
}
