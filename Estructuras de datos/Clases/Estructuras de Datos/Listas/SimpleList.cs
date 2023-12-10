using System;
using System.Windows.Forms;

namespace Estructuras_de_datos
{
    class SimpleList<T> : ImethodLists<T>
    {
        private Node<T> Head { get; set; }

        public int Lenght { get; set; }

        public SimpleList()
        {
            Clear();
        }

        public void Add(T data)
        {
            Node<T> NewNode = new Node<T>(data);
            if (IsEmpty())
            {
                Head = NewNode;
                Lenght++;
                return;
            }
            if (Exist(NewNode.Data))
            {
                return;
            }
            if (NewNode.CompareTo(Head) <= 0)
            {
                NewNode.Next = Head;
                Head = NewNode;
                Lenght++;
                return;
            }
            Node<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.CompareTo(NewNode) < 0)
            {
                CurrentNode = CurrentNode.Next;
            }
            NewNode.Next = CurrentNode.Next;
            CurrentNode.Next = NewNode;
            Lenght++;
        }

        public void Delete(T data)
        {
            if (IsEmpty())
            {
                return;
            }
            if (object.Equals(Head.Data, data))
            {
                Head = Head.Next;
                Lenght--;
                return;
            }
            Node<T> CurrentNode = Head;
            while (CurrentNode.Next != null && !object.Equals(CurrentNode.Next.Data, data))
            {
                CurrentNode = CurrentNode.Next;
            }
            if (CurrentNode.Next != null && object.Equals(CurrentNode.Next.Data, data))
            {
                CurrentNode.Next = CurrentNode.Next.Next;
                Lenght--;
                return;
            }
        }

        public void Search(T data)
        {
            if (IsEmpty())
            {
                return;
            }
            if (object.Equals(Head.Data, data))
            {
                return;
            }
            Node<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.CompareTo(data) < 0)
            {
                CurrentNode = CurrentNode.Next;
            }
            if (object.Equals(CurrentNode.Data, data))
            {
                return;
            }
        }

        public void Show()
        {
            if (IsEmpty())
            {
                return;
            }
            int i = 0;
            Node<T> CurrentNode = Head;
            while (CurrentNode != null)
            {
                CurrentNode = CurrentNode.Next;
                i++;
            }
        }

        public void ShowRevers()
        {
            if (IsEmpty())
            {
                return;
            }
            Node<T> CurrentNode = Head;
            int x = 0;
            for (int i = Lenght - 1; i > -1; i--)
            {
                CurrentNode = Head;
                x = 0;
                while (CurrentNode != null && x != i)
                {
                    CurrentNode = CurrentNode.Next;
                    x++;
                }
            }
        }

        public bool Exist(T data)
        {
            if (IsEmpty())
            {
                return false;
            }
            if (object.Equals(Head.Data, data))
            {
                return true;
            }
            Node<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.CompareTo(data) < 0)
            {
                CurrentNode = CurrentNode.Next;
            }
            if (object.Equals(CurrentNode.Data, data))
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Clear()
        {
            Head = null;
        }

        public int Count()
        {
            int count = 0;
            Node<T> copy_head = Head;
            while (copy_head != null)
            {
                count++;
                copy_head = copy_head.Next;
            }
            return count;
        }

        public string[] ToString2()
        {
            Node<T> copy_head = Head;
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