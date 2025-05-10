using ElEscribaNET.Models;

namespace ElEscribaNETinstancia.Utilities
{
    class PersonaUtil
    {
        public bool CompararPorDNI(Persona p1, Persona p2)
        {

            return p1.DNI == p2.DNI;
        }
    }
}
