using System;
using System.Windows.Forms;

namespace Estructuras_de_datos
{
    class StackStatic<T>
    {
        private T[] Elements;
        public int Ability;
        private int Contain;

        public StackStatic(int ability)
        {
            this.Ability = ability;
            this.Elements = new T[ability];
            this.Contain = 0;
        }

        public StackStatic()
        {
            this.Ability = 0;
            this.Elements = new T[0];
            this.Contain = 0;
        }

        public void Push(T element)
        {
            if (Count < Ability)
            {
                Elements[Contain] = element;
                Contain++;
            }
            else
            {
                MessageBox.Show("Static Stack Full!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public T Pop()
        {
            if (Contain > 0)
            {
                Contain--;
                T elemento = Elements[Contain];
                Elements[Contain] = default(T); // Restablecer el valor a su valor predeterminado
                return elemento;
            }
            else
            {
                MessageBox.Show("Void Static Stack", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return default(T); // Valor predeterminado para el tipo T (por ejemplo, null para referencias)
            }
        }

        public T Peek()
        {
            if (Contain > 0)
            {
                MessageBox.Show($"Peek Static Stack: {Elements[Contain - 1]}", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return Elements[Contain - 1];
            }
            else
            {
                MessageBox.Show("Void Stack", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return default(T); // Valor predeterminado para el tipo T
            }
        }

        public string Show(StackStatic<T> stack)
        {
            string Message = "";
            if (stack.Count == 0)
            {
                return Message;
            }
            while (stack.Count > 0)
            {
                Message += stack.Pop().ToString();
            }
            return Message;
        }

        public int Count
        {
            get { return Contain; }
        }

        public string[] ToString2()
        {
            string[] r = new string[this.Count];
            for (int i = 0; i < Count; i++)
            {
                r[i] += Elements[i];
            }
            return r;
        }
    }
}