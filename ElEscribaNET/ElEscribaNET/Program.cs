using ElEscribaNET.Models;
using System;

namespace ElEscriba.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo objeto_1 = new Vehiculo("Auto", "AA333BB");
            Vehiculo objeto_2 = new Vehiculo("Auto", "AA333BB");
            Persona objeto_3 = new Persona("Gabriel", "41.454.655");
            Vehiculo objeto_4 = new Vehiculo("Camión", "AB123AB");
            Vehiculo objeto_5 = new Vehiculo("Colectivo", "BA333BA");
            Persona objeto_6 = new Persona("Ana", "43.789.242");

            string salida = "";

            #region tabla 1: listado de personas
            Console.WriteLine("Listado de personas");

            salida =objeto_3.Ver();
            Console.WriteLine(salida);

            salida = objeto_6.Ver();
            Console.WriteLine(salida);
            #endregion 

            #region tabla2: listado de vehículos
            Console.WriteLine("Listado de vehículos");

            salida = objeto_1.Ver();
            Console.WriteLine(salida);

            salida = objeto_2.Ver();
            Console.WriteLine(salida);

            salida = objeto_4.Ver();
            Console.WriteLine(salida);
            #endregion
        }
    }
}
