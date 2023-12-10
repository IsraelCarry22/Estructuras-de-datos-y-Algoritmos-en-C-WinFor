using Estructuras_de_datos.Clases.Estructuras_de_Datos;
using System.Windows.Forms;

namespace Estructuras_de_datos
{
    class Queue
    {
        private Nodo Head { get; set; }
        private Nodo LastNode { get; set; }

        public Queue()
        {
            Head = null;
            LastNode = null;
        }

        public void Enqueue(int data)
        {
            Nodo NewNode = new Nodo(data);
            if (IsEmpty())
            {
                Head = NewNode;
                LastNode = NewNode;
                return;
            }
            if (Exist(NewNode.Data))
            {
                return;
            }
            if (NewNode.Data < Head.Data)
            {
                NewNode.Next = Head;
                Head = NewNode;
                return;
            }
            Nodo CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.Data < NewNode.Data)
            {
                CurrentNode = CurrentNode.Next;
            }
            NewNode.Next = CurrentNode.Next;
            CurrentNode.Next = NewNode;
            CurrentNode = Head;
            while (CurrentNode.Next != null)
            {
                CurrentNode = CurrentNode.Next;
            }
            LastNode = CurrentNode;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Void Queue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Head.Next != null)
            {
                Head = Head.Next;
                return;
            }
            Clear();
        }

        private bool Exist(int data)
        {
            if (IsEmpty())
            {
                return false;
            }
            if (Head.Data == data)
            {
                return true;
            }
            Nodo CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.Data < data)
            {
                CurrentNode = CurrentNode.Next;
            }
            if (CurrentNode.Data == data)
            {
                return true;
            }
            return false;
        }

        private bool IsEmpty()
        {
            return Head == null;
        }

        public void Clear()
        {
            Head = null;
            LastNode = null;
        }

        public int Count()
        {
            int count = 0;
            Nodo copy_head = Head;
            while (copy_head != null)
            {
                count++;
                copy_head = copy_head.Next;
            }
            return count;
        }

        public string[] ToString2()
        {
            Nodo copy_head = Head;
            string[] r = new string[this.Count()];
            int index = 0;
            while (copy_head != null)
            {
                r[index] += copy_head.Data.ToString();
                copy_head = copy_head.Next;
                index++;
            }
            return r;
        }
    }
}