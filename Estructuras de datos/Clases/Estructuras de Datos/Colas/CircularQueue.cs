using System.Collections.Generic;
using System.Windows.Forms;

namespace Estructuras_de_datos
{
    class CircularQueue
    {
        private int Size, Front, Rear;
        private List<int> Queue = new List<int>();

        public CircularQueue(int size)
        {
            this.Size = size;
            this.Front = this.Rear = -1;
        }

        public void Enqueue(int Value)
        {
            if ((Front == 0 && Rear == Size - 1) || (Rear == (Front - 1) % (Size - 1)))
            {
                MessageBox.Show("Circular Queue is Full!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Front == -1)
            {
                Front = 0;
                Rear = 0;
                Queue.Add(Value);
            }
            else if (Rear == Size - 1 && Front != 0)
            {
                Rear = 0;
                Queue[Rear] = Value;
            }
            else
            {
                Rear = (Rear + 1);
                if (Front <= Rear)
                {
                    Queue.Add(Value);
                }
                else
                {
                    Queue[Rear] = Value;
                }
            }
        }

        public void Dequeue()
        {
            if (Front == -1)
            {
                MessageBox.Show("Void Circular Queue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Front == Rear)
            {
                Front = -1;
                Rear = -1;
            }
            else if (Front == Size - 1)
            {
                Front = 0;
            }
            else
            {
                if (Front == Queue.Count)
                {
                    MessageBox.Show("Void Circular Queue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Queue.Remove(Queue[Front]);
            }
        }

        public void Clear()
        {
            Queue.Clear();
        }

        public string[] ToString2()
        {
            string[] r = new string[Queue.Count];
            for (int i = 0; i < Queue.Count; i++)
            {
                r[i] += Queue[i];
            }
            return r;
        }
    }
}