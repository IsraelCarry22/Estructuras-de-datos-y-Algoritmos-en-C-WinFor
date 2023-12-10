using DataStructuresAndAlgorithms_InCSharp.Classes.Tree;
using Estructuras_de_datos.Clases.Algoritmos;
using Estructuras_de_datos.Clases.Estructuras_de_Datos;
using Estructuras_de_datos.Clases.Estructuras_de_Datos.Nodos;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Estructuras_de_datos
{
    public partial class Form1 : Form
    {
        readonly Random random;
        readonly StackStatic<int> stackS;
        readonly StackDinamic<int> stackD;
        readonly Queue queue;
        readonly CircularQueue circularqueue;
        readonly PriorityQueue<int> priorityQueue;
        readonly SimpleList<int> simpleList;
        readonly CircularList<int> circularList;
        readonly DoublyListLinked<int> doublyListLinked;
        readonly CircularDoublyLinkedList<int> circularDoublyLinkedList;
        readonly BinaryTree binaryTree;
        readonly DirectedGraph directedGraph;
        readonly CallAllAlgorithm call;

        public Form1()
        {
            random = new Random();
            stackS = new StackStatic<int>(20);
            stackD = new StackDinamic<int>();
            queue = new Queue();
            circularqueue = new CircularQueue(20);
            priorityQueue = new PriorityQueue<int>();
            simpleList = new SimpleList<int>();
            circularList = new CircularList<int>();
            doublyListLinked = new DoublyListLinked<int>();
            circularDoublyLinkedList = new CircularDoublyLinkedList<int>();
            binaryTree = new BinaryTree();
            directedGraph = new DirectedGraph();
            call = new CallAllAlgorithm();
            InitializeComponent();
        }

        private void StackMenu_Click(object sender, EventArgs e)
        {
            p_queue.Visible = false;
        }

        private void QueueMenu_Click(object sender, EventArgs e)
        {
            p_queue.Visible = true;
            p_list.Visible = false;
        }

        private void ListMenu_Click(object sender, EventArgs e)
        {
            p_queue.Visible = true;
            p_list.Visible = true;
            p_Tree.Visible = false;
        }

        private void TreeMenu_Click(object sender, EventArgs e)
        {
            p_queue.Visible = true;
            p_list.Visible = true;
            p_Tree.Visible = true;
            p_Graph.Visible = false;
        }

        private void GraphMenu_Click(object sender, EventArgs e)
        {
            p_queue.Visible = true;
            p_list.Visible = true;
            p_Tree.Visible = true;
            p_Graph.Visible = true;
            p_Algorithm.Visible = false;
        }
        private void AlgorithmMenu_Click_1(object sender, EventArgs e)
        {
            p_queue.Visible = true;
            p_list.Visible = true;
            p_Tree.Visible = true;
            p_Graph.Visible = true;
            p_Algorithm.Visible = true;
        }

        private void Push_Stack_Click(object sender, EventArgs e)
        {
            int Data = 0;
            try { Data = int.Parse(TexBox_Push_Stack.Text); } catch { }

            stackS.Push(Data);
            stackD.Push(Data);

            Show(stackS.ToString2(), ListView_StackS);
            Show(stackD.ToString2(), ListView_StackD);


            TexBox_Push_Stack.Clear();
            TexBox_Push_Stack.Focus(); 
        }

        private void Pop_Stack_Click(object sender, EventArgs e)
        {
            stackS.Pop();
            stackD.Pop();

            Show(stackS.ToString2(), ListView_StackS);
            Show(stackD.ToString2(), ListView_StackD);
        }

        private void Peek_Stack_Click(object sender, EventArgs e)
        {
            stackS.Peek();
            stackD.Peek();
        }

        private void Enqueue_Queue_Click(object sender, EventArgs e)
        {
            int Data = 0;
            try { Data = int.Parse(TexBox_Enqueue_Queue.Text); } catch { }

            queue.Enqueue(Data);
            circularqueue.Enqueue(Data);
            priorityQueue.Enqueue(Data, 0);

            Show(queue.ToString2(), ListView_Queue);
            Show(circularqueue.ToString2(), ListView_CircularQueue);
            Show(priorityQueue.ToString2(), ListView_PriorityQueue);

            TexBox_Enqueue_Queue.Clear();
            TexBox_Enqueue_Queue.Focus();
        }

        private void Dequeue_Queue_Click(object sender, EventArgs e)
        {
            queue.Dequeue();
            circularqueue.Dequeue();
            priorityQueue.Dequeue();

            Show(queue.ToString2(), ListView_Queue);
            Show(circularqueue.ToString2(), ListView_CircularQueue);
            Show(priorityQueue.ToString2(), ListView_PriorityQueue);
        }

        private void Priority_Queue_Click(object sender, EventArgs e)
        {
            int Data1 = 0;
            try { Data1 = int.Parse(TexBox_Enqueue_Queue.Text); } catch { }
            int Data2 = 0;
            try { Data2 = int.Parse(TexBox_Enqueue_PriorityQueue.Text); } catch { }

            priorityQueue.Enqueue(Data1, Data2);

            Show(priorityQueue.ToString2(), ListView_PriorityQueue);

            TexBox_Enqueue_Queue.Clear();
            TexBox_Enqueue_PriorityQueue.Clear();
            TexBox_Enqueue_Queue.Focus();
            TexBox_Enqueue_PriorityQueue.Focus();
        }

        private void Add_List_Click(object sender, EventArgs e)
        {
            int Data = 0;
            try { Data = int.Parse(TexBox_Add_List.Text); } catch { }

            simpleList.Add(Data);
            circularList.Add(Data);
            doublyListLinked.Add(Data);
            circularDoublyLinkedList.Add(Data);

            Show(simpleList.ToString2(), ListView_SimpleList);
            Show(circularList.ToString2(), ListView_CircularList);
            Show(doublyListLinked.ToString2(), ListView_DoublyLinkedList);
            Show(circularDoublyLinkedList.ToString2(), ListView_CircularDoublyLinkedList);

            TexBox_Add_List.Clear();
            TexBox_Add_List.Focus();
        }

        private void Delete_List_Click(object sender, EventArgs e)
        {
            int Data = 0;
            try { Data = int.Parse(TexBox_Delete_List.Text); } catch { }

            simpleList.Delete(Data);
            circularList.Delete(Data);
            doublyListLinked.Delete(Data);
            circularDoublyLinkedList.Delete(Data);

            Show(simpleList.ToString2(), ListView_SimpleList);
            Show(circularList.ToString2(), ListView_CircularList);
            Show(doublyListLinked.ToString2(), ListView_DoublyLinkedList);
            Show(circularDoublyLinkedList.ToString2(), ListView_CircularDoublyLinkedList);

            TexBox_Delete_List.Clear();
            TexBox_Delete_List.Focus();
        }

        private void Generate_List_Click(object sender, EventArgs e)
        {
            int Data = 0;
            try { Data = int.Parse(TexBox_Generate_List.Text); } catch { }

            Generate(Data);

            Show(simpleList.ToString2(), ListView_SimpleList);
            Show(circularList.ToString2(), ListView_CircularList);
            Show(doublyListLinked.ToString2(), ListView_DoublyLinkedList);
            Show(circularDoublyLinkedList.ToString2(), ListView_CircularDoublyLinkedList);

            TexBox_Generate_List.Clear();
            TexBox_Generate_List.Focus();
        }

        public void Generate(int N)
        {
            for (int i = 0; i < N; i++)
            {
                simpleList.Add(random.Next(10000));
                circularList.Add(random.Next(10000));
                doublyListLinked.Add(random.Next(10000));
                circularDoublyLinkedList.Add(random.Next(10000));
            }
        }

        public void Show(string[] dataArray, ListBox list)
        {
            list.Items.Clear();
            for (int index = 0; index < dataArray.Length; index++)
            {
                if (dataArray[index] == null)
                {
                    MessageBox.Show("Item array is null");
                    continue;
                }
                list.Items.Add(dataArray[index]);
            }
        }

        private void Add_BinaryTree_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TexBox_Add_BinaryTree.Text, out var number))
            {
                MessageBox.Show("Only numbers in the 'numbers' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            binaryTree.Add(number);

            ToursOfTree();

            int Data = 0;
            try { Data = int.Parse(TexBox_Add_BinaryTree.Text); } catch { }

            binaryTree.Add(Data);

            Treeview(binaryTree.Root, null, TreeView.Nodes);

            TexBox_Add_BinaryTree.Clear();
            TexBox_Add_BinaryTree.Focus();
        }

        private void Delete_BinaryTree_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TexBox_Delete_BinaryTree.Text, out var number))
            {
                MessageBox.Show("Only numbers in the 'numbers' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            binaryTree.Delete(number);
            ToursOfTree();

            TexBox_Delete_BinaryTree.Clear();
            TexBox_Delete_BinaryTree.Focus();
        }

        private void Search_BinaryTree_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TexBox_Search_BinaryTree.Text, out var number))
            {
                MessageBox.Show("Only numbers in the 'numbers' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            binaryTree.Search(number);

            TexBox_Search_BinaryTree.Clear();
            TexBox_Search_BinaryTree.Focus();
        }

        public void Treeview(BinaryNode Tree, TreeNode parentNode, TreeNodeCollection nodes)
        {
            if (Tree != null)
            {
                var NewNode = new TreeNode(Tree.Data.ToString());
                if (parentNode != null)
                {
                    parentNode.Nodes.Add(NewNode);
                }
                else
                {
                    nodes.Add(NewNode);
                }
                Treeview(Tree.Left, NewNode, NewNode.Nodes);
                Treeview(Tree.Right, NewNode, NewNode.Nodes);
            }
        }

        public void ToursOfTree()
        {
            ListView_PreOden.Items.Clear();
            foreach (int val in binaryTree.GetPreOrden())
            {
                ListView_PreOden.Items.Add(val.ToString());
            }

            ListView_PostOden.Items.Clear();
            foreach (int val in binaryTree.GetPostOrden())
            {
                ListView_PostOden.Items.Add(val.ToString());
            }

            ListView_InOden.Items.Clear();
            foreach (int val in binaryTree.GetInOrden())
            {
                ListView_InOden.Items.Add(val.ToString());
            }
        }

        static void VisualizarArbol(Nodo Tree, TreeNode parentNode, TreeNodeCollection nodes)
        {
            if (Tree != null)
            {
                var NewNode = new TreeNode(Tree.Data.ToString());

                if (parentNode != null)
                {
                    parentNode.Nodes.Add(NewNode);
                }
                else
                {
                    nodes.Add(NewNode);
                }

                VisualizarArbol(Tree.Left, NewNode, NewNode.Nodes);
                VisualizarArbol(Tree.Right, NewNode, NewNode.Nodes);
            }
        }

        private void Add_Edge_Graph_Click(object sender, EventArgs e)
        {
            string origin, destination;

            origin = TextBox_Origin.Text;
            destination = TextBox_Destination.Text;

            directedGraph.AddEdge(origin, destination);

            UpdateViewGraph();

            TextBox_Origin.Clear();
            TextBox_Destination.Clear();
        }

        private void Add_Vertex_Graph_Click(object sender, EventArgs e)
        {
            string name;

            name = TextBox_Add_vertex.Text;

            directedGraph.AddVertex(name);

            UpdateViewGraph();

            TextBox_Add_vertex.Clear();
            TextBox_Add_vertex.Focus();
        }

        private void UpdateViewGraph()
        {
            Bitmap imagenGrafo = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(imagenGrafo))
            {

                foreach (var vertice in directedGraph._Vertex)
                {
                    g.FillEllipse(Brushes.Blue, vertice.Valor.X, vertice.Valor.Y, 30, 30);
                    g.DrawString(vertice.Nombre, DefaultFont, Brushes.White, vertice.Valor.X + 8, vertice.Valor.Y + 8);
                }

                foreach (var arista in directedGraph._Edge)
                {
                    g.DrawLine(Pens.Black, arista.Origen.Valor.X + 15, arista.Origen.Valor.Y + 15,
                                         arista.Destino.Valor.X + 15, arista.Destino.Valor.Y + 15);
                }
            }
            pictureBox1.Image = imagenGrafo;
        }

        private void Show_Algorithm_Click(object sender, EventArgs e)
        {
            Textbox_Algorithm.Clear();

            string option = Case_Algorithm.Text;

            switch (option)
            {
                case "BubbleSort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._BubbleSort.bubbleSort(array);
                    Textbox_Algorithm.Text += ("BubbleSort: ");
                    break;
                case "Cocktailsort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._Cocktailsort.cocktailSort(array);
                    Textbox_Algorithm.Text += ("Cocktailsort: ");
                    break;
                case "Insertionsort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._Insertionsort.InsertionSortAlgorithm(array);
                    Textbox_Algorithm.Text += ("Insertionsort: ");
                    break;
                case "BucketSort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._BucketSort.BucketSort_int(array, Textbox_Algorithm);
                    Textbox_Algorithm.Text += ("BucketSort: ");
                    break;
                case "Countingsort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._Countingsort.Sort(array);
                    Textbox_Algorithm.Text += ("Countingsort: ");
                    break;
                case "Mergesort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._Countingsort.Sort(array);
                    Textbox_Algorithm.Text += ("Mergesort: ");
                    break;
                case "Binarytreesort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._Binarytreesort.Sort(array);
                    Textbox_Algorithm.Text += ("Binarytreesort: ");
                    break;
                case "Pigeonhole":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._Pigeonhole.PigeonholeSort(array);
                    Textbox_Algorithm.Text += ("Pigeonhole: ");
                    break;
                case "Radixsort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._Radixsort.Sort(array);
                    Textbox_Algorithm.Text += ("Radixsort: ");
                    break;
                case "Gnomesort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._Gnomesort.Sort(array);
                    Textbox_Algorithm.Text += ("Gnomesort: ");
                    break;
                case "Shellsort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._Shellsort.Shell_Sort(array, Textbox_Algorithm);
                    Textbox_Algorithm.Text += ("Shellsort: ");
                    break;
                case "Combsort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._Combsort.Sort(array);
                    Textbox_Algorithm.Text += ("Combsort: ");
                    break;
                case "Selectionsort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._Selectionsort.Sort(array);
                    Textbox_Algorithm.Text += ("Selectionsort: ");
                    break;
                case "Heapsort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._Heapsort.Sort(array);
                    Textbox_Algorithm.Text += ("Heapsort: ");
                    break;
                case "QuickSort":
                    Textbox_Algorithm.Text = string.Empty;
                    Textbox_Algorithm.Text += ("Arreglo inicial: ");
                    PrintArray(array, Textbox_Algorithm);
                    call._QuickSort.quicksort(ref array, 0, array.Length - 1, Textbox_Algorithm);
                    Textbox_Algorithm.Text += ("QuickSort: ");
                    break;
            }

            PrintArray(array, Textbox_Algorithm);
        }

        public static int[] array;
        private void Generate_Array_Click(object sender, EventArgs e)
        {
            Textbox_Algorithm.Clear();

            int size = int.Parse(TextBox_Size_Array.Text);

            array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(10000);
            }

            PrintArray(array, Textbox_Algorithm);
        }

        private void PrintArray(int[] array, System.Windows.Forms.TextBox txtBox)
        {
            if (array == null)
            {
                txtBox.Clear();
            }
            txtBox.Text += ("[" + string.Join(", ", array) + "]\r\n");
        }
    }
}