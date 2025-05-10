using ElEscribaNET.Models;
using ElEscribaNETinstancia.Utilities;
using System;

namespace ElEscribaNETstatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //preparo el escenario

            Persona gabi = new Persona("Gabriel", "41.454.655");
            Persona ana = new Persona("Ana", "43.789.242");

            //no necesito instanciación

            //llamada al método de clase
            if (PersonaUtil.CompararPorDNI(gabi, ana) == true)
            {
                Console.WriteLine("Tienen el mismo DNI");
            }
            else
            {
                Console.WriteLine("No Tienen el mismo DNI");
            }
        }
    }
}
