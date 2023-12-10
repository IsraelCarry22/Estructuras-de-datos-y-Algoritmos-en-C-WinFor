namespace Estructuras_de_datos.Clases.Estructuras_de_Datos.Nodos
{
    public class BinaryNode
    {
        public int Data;
        public BinaryNode Left, Right;

        public BinaryNode(int value)
        {
            Data = value;
            Left = Right = null;
        }
    }
}
