namespace ElEscribaNET.Models
{
    class Persona
    {
        public string Nombre;
        public string DNI;

        //método constructor
        public Persona(string nombre,  string dni)
        {
            Nombre = nombre;
            DNI = dni;
        }

        //método estándar.
        public string Ver()
        {
            return "Nombre :" + Nombre + ", DNI: " + DNI;
        }
    }
}
