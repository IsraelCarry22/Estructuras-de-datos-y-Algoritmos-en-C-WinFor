using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Estructuras_de_datos
{
    class StackDinamic<T>
    {
        private List<T> Stack;
        public int Count;

        public T this[int index]
        {
            get { return Stack[index]; }
        }

        public StackDinamic()
        {
            Stack = new List<T>();
        }

        public void Push(T item)
        {
            Stack.Add(item);
            Count++;
        }

        public T Pop()
        {
            if (Stack.Count == 0)
            {
                MessageBox.Show("Void Dinamic Stack", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return default(T);
            }

            int lastIndex = Stack.Count - 1;
            T poppedItem = Stack[lastIndex];
            Stack.RemoveAt(lastIndex);
            Count--;
            return poppedItem;
        }

        public T Peek()
        {
            if (Stack.Count == 0)
            {
                MessageBox.Show("Void Dinamic Stack", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return default(T);
            }
            MessageBox.Show($"Peek Dinamic Stack: {Stack[Stack.Count - 1]}", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Stack[Stack.Count - 1];
        }

        public string[] ToString2()
        {
            string[] r = new string[this.Count];
            for (int i = 0; i < Count; i++)
            {
                r[i] += Stack[i];
            }
            return r;
        }
    }
}