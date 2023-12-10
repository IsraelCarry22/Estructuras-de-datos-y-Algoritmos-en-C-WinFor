namespace Estructuras_de_datos.Clases.Estructuras_de_Datos.Grafos
{
    internal class Edge
    {
        public Vertex Origen { get; set; }
        public Vertex Destino { get; set; }

        public Edge(Vertex origen, Vertex destino)
        {
            Origen = origen;
            Destino = destino;
        }
    }
}
