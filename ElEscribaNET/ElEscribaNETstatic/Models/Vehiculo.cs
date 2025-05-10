namespace ElEscriba.NET.Models
{
    class Vehiculo
    {
        public string Categoria;
        public string Patente;

        //método constructor
        public Vehiculo(string categoria, string patente)
        {
            Categoria = categoria;
            Patente = patente;
        }

        //método estándar.
        public string Ver()
        {
            return "Categoría :" + Categoria + ", Patente: " + Patente;
        }
    }
}
