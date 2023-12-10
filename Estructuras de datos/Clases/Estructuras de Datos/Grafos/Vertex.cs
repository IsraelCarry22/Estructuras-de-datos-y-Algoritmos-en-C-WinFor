using System.Drawing;

namespace Estructuras_de_datos.Clases.Estructuras_de_Datos.Grafos
{
    internal class Vertex
    {
        public string Nombre { get; set; }
        public Point Valor { get; set; }

        public Vertex(string nombre, Point valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
    }
}
