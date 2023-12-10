namespace Estructuras_de_datos.Clases.Estructuras_de_Datos
{
    class Nodo
    {
        public Nodo Left { get; set; }
        public Nodo Right { get; set; }
        public Nodo Next { get; set; }
        public int Data { get; set; }

        public Nodo(int Data)
        {
            this.Data = Data;
            Left = null;
            Right = null;
        }
    }
}