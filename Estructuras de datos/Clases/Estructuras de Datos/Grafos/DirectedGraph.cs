using Estructuras_de_datos.Clases.Estructuras_de_Datos.Grafos;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Estructuras_de_datos
{
    internal class DirectedGraph
    {
        private Random _random = new Random();
        public List<Vertex> _Vertex { get; }
        public List<Edge> _Edge { get; }

        public DirectedGraph()
        {
            _Vertex = new List<Vertex>();
            _Edge = new List<Edge>();
        }

        public void AddVertex(string name)
        {
            // Añadir un vértice a posiciones aleatorias en el PictureBox
            Vertex NewVertex = new Vertex(name, new Point(_random.Next(0, 400), _random.Next(0, 300)));
            _Vertex.Add(NewVertex);
        }

        public void AddEdge(string origin, string destination)
        {
            // Añadir una arista entre los vértices con los nombres dados
            Vertex OriginVertx = _Vertex.Find(v => v.Nombre == origin);
            Vertex DestinationVertx = _Vertex.Find(v => v.Nombre == destination);

            if (OriginVertx != null && DestinationVertx != null)
            {
                _Edge.Add(new Edge(OriginVertx, DestinationVertx));
            }
        }
    }
}