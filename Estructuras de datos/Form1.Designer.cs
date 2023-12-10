namespace Estructuras_de_datos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StackMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QueueMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AlgorithmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Peek_Stack = new System.Windows.Forms.Button();
            this.Pop_Stack = new System.Windows.Forms.Button();
            this.Push_Stack = new System.Windows.Forms.Button();
            this.TexBox_Push_Stack = new System.Windows.Forms.TextBox();
            this.ListView_StackS = new System.Windows.Forms.ListBox();
            this.ListView_StackD = new System.Windows.Forms.ListBox();
            this.p_queue = new System.Windows.Forms.Panel();
            this.p_list = new System.Windows.Forms.Panel();
            this.p_Tree = new System.Windows.Forms.Panel();
            this.p_Graph = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBox_Destination = new System.Windows.Forms.TextBox();
            this.TextBox_Origin = new System.Windows.Forms.TextBox();
            this.Add_Edge_Graph = new System.Windows.Forms.Button();
            this.TextBox_Add_vertex = new System.Windows.Forms.TextBox();
            this.Add_Vertex_Graph = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListView_InOden = new System.Windows.Forms.ListView();
            this.ListView_PostOden = new System.Windows.Forms.ListView();
            this.ListView_PreOden = new System.Windows.Forms.ListView();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TexBox_Search_BinaryTree = new System.Windows.Forms.TextBox();
            this.Search_BinaryTree = new System.Windows.Forms.Button();
            this.TexBox_Delete_BinaryTree = new System.Windows.Forms.TextBox();
            this.Delete_BinaryTree = new System.Windows.Forms.Button();
            this.TexBox_Add_BinaryTree = new System.Windows.Forms.TextBox();
            this.Add_BinaryTree = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.TexBox_Generate_List = new System.Windows.Forms.TextBox();
            this.Generate_List = new System.Windows.Forms.Button();
            this.TexBox_Delete_List = new System.Windows.Forms.TextBox();
            this.Delete_List = new System.Windows.Forms.Button();
            this.ListView_CircularDoublyLinkedList = new System.Windows.Forms.ListBox();
            this.ListView_DoublyLinkedList = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ListView_CircularList = new System.Windows.Forms.ListBox();
            this.ListView_SimpleList = new System.Windows.Forms.ListBox();
            this.TexBox_Add_List = new System.Windows.Forms.TextBox();
            this.Add_List = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TexBox_Enqueue_PriorityQueue = new System.Windows.Forms.TextBox();
            this.Priority_Queue = new System.Windows.Forms.Button();
            this.ListView_PriorityQueue = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ListView_CircularQueue = new System.Windows.Forms.ListBox();
            this.ListView_Queue = new System.Windows.Forms.ListBox();
            this.TexBox_Enqueue_Queue = new System.Windows.Forms.TextBox();
            this.Dequeue_Queue = new System.Windows.Forms.Button();
            this.Enqueue_Queue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p_Algorithm = new System.Windows.Forms.Panel();
            this.Show_Algorithm = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.Case_Algorithm = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TextBox_Size_Array = new System.Windows.Forms.TextBox();
            this.Textbox_Algorithm = new System.Windows.Forms.TextBox();
            this.Generate_Array = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.p_queue.SuspendLayout();
            this.p_list.SuspendLayout();
            this.p_Tree.SuspendLayout();
            this.p_Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p_Algorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StackMenu,
            this.QueueMenu,
            this.ListMenu,
            this.TreeMenu,
            this.GraphMenu,
            this.AlgorithmMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StackMenu
            // 
            this.StackMenu.Name = "StackMenu";
            this.StackMenu.Size = new System.Drawing.Size(47, 20);
            this.StackMenu.Text = "Stack";
            this.StackMenu.Click += new System.EventHandler(this.StackMenu_Click);
            // 
            // QueueMenu
            // 
            this.QueueMenu.Name = "QueueMenu";
            this.QueueMenu.Size = new System.Drawing.Size(54, 20);
            this.QueueMenu.Text = "Queue";
            this.QueueMenu.Click += new System.EventHandler(this.QueueMenu_Click);
            // 
            // ListMenu
            // 
            this.ListMenu.Name = "ListMenu";
            this.ListMenu.Size = new System.Drawing.Size(37, 20);
            this.ListMenu.Text = "List";
            this.ListMenu.Click += new System.EventHandler(this.ListMenu_Click);
            // 
            // TreeMenu
            // 
            this.TreeMenu.Name = "TreeMenu";
            this.TreeMenu.Size = new System.Drawing.Size(40, 20);
            this.TreeMenu.Text = "Tree";
            this.TreeMenu.Click += new System.EventHandler(this.TreeMenu_Click);
            // 
            // GraphMenu
            // 
            this.GraphMenu.Name = "GraphMenu";
            this.GraphMenu.Size = new System.Drawing.Size(51, 20);
            this.GraphMenu.Text = "Graph";
            this.GraphMenu.Click += new System.EventHandler(this.GraphMenu_Click);
            // 
            // AlgorithmMenu
            // 
            this.AlgorithmMenu.Name = "AlgorithmMenu";
            this.AlgorithmMenu.Size = new System.Drawing.Size(73, 20);
            this.AlgorithmMenu.Text = "Algorithm";
            this.AlgorithmMenu.Click += new System.EventHandler(this.AlgorithmMenu_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stack Static";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stack Dinamic";
            // 
            // Peek_Stack
            // 
            this.Peek_Stack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peek_Stack.Location = new System.Drawing.Point(498, 193);
            this.Peek_Stack.Name = "Peek_Stack";
            this.Peek_Stack.Size = new System.Drawing.Size(147, 39);
            this.Peek_Stack.TabIndex = 12;
            this.Peek_Stack.Text = "Peek";
            this.Peek_Stack.UseVisualStyleBackColor = true;
            this.Peek_Stack.Click += new System.EventHandler(this.Peek_Stack_Click);
            // 
            // Pop_Stack
            // 
            this.Pop_Stack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pop_Stack.Location = new System.Drawing.Point(498, 151);
            this.Pop_Stack.Name = "Pop_Stack";
            this.Pop_Stack.Size = new System.Drawing.Size(147, 39);
            this.Pop_Stack.TabIndex = 11;
            this.Pop_Stack.Text = "Pop";
            this.Pop_Stack.UseVisualStyleBackColor = true;
            this.Pop_Stack.Click += new System.EventHandler(this.Pop_Stack_Click);
            // 
            // Push_Stack
            // 
            this.Push_Stack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Push_Stack.Location = new System.Drawing.Point(498, 109);
            this.Push_Stack.Name = "Push_Stack";
            this.Push_Stack.Size = new System.Drawing.Size(147, 39);
            this.Push_Stack.TabIndex = 10;
            this.Push_Stack.Text = "Push";
            this.Push_Stack.UseVisualStyleBackColor = true;
            this.Push_Stack.Click += new System.EventHandler(this.Push_Stack_Click);
            // 
            // TexBox_Push_Stack
            // 
            this.TexBox_Push_Stack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Push_Stack.Location = new System.Drawing.Point(498, 75);
            this.TexBox_Push_Stack.Name = "TexBox_Push_Stack";
            this.TexBox_Push_Stack.Size = new System.Drawing.Size(147, 28);
            this.TexBox_Push_Stack.TabIndex = 19;
            // 
            // ListView_StackS
            // 
            this.ListView_StackS.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_StackS.FormattingEnabled = true;
            this.ListView_StackS.ItemHeight = 21;
            this.ListView_StackS.Location = new System.Drawing.Point(100, 76);
            this.ListView_StackS.Name = "ListView_StackS";
            this.ListView_StackS.Size = new System.Drawing.Size(164, 382);
            this.ListView_StackS.TabIndex = 20;
            // 
            // ListView_StackD
            // 
            this.ListView_StackD.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_StackD.FormattingEnabled = true;
            this.ListView_StackD.ItemHeight = 21;
            this.ListView_StackD.Location = new System.Drawing.Point(301, 76);
            this.ListView_StackD.Name = "ListView_StackD";
            this.ListView_StackD.Size = new System.Drawing.Size(164, 382);
            this.ListView_StackD.TabIndex = 21;
            // 
            // p_queue
            // 
            this.p_queue.Controls.Add(this.p_list);
            this.p_queue.Controls.Add(this.TexBox_Enqueue_PriorityQueue);
            this.p_queue.Controls.Add(this.Priority_Queue);
            this.p_queue.Controls.Add(this.ListView_PriorityQueue);
            this.p_queue.Controls.Add(this.label5);
            this.p_queue.Controls.Add(this.ListView_CircularQueue);
            this.p_queue.Controls.Add(this.ListView_Queue);
            this.p_queue.Controls.Add(this.TexBox_Enqueue_Queue);
            this.p_queue.Controls.Add(this.Dequeue_Queue);
            this.p_queue.Controls.Add(this.Enqueue_Queue);
            this.p_queue.Controls.Add(this.label3);
            this.p_queue.Controls.Add(this.label4);
            this.p_queue.Location = new System.Drawing.Point(12, 27);
            this.p_queue.Name = "p_queue";
            this.p_queue.Size = new System.Drawing.Size(707, 431);
            this.p_queue.TabIndex = 22;
            this.p_queue.Visible = false;
            // 
            // p_list
            // 
            this.p_list.Controls.Add(this.p_Tree);
            this.p_list.Controls.Add(this.TexBox_Generate_List);
            this.p_list.Controls.Add(this.Generate_List);
            this.p_list.Controls.Add(this.TexBox_Delete_List);
            this.p_list.Controls.Add(this.Delete_List);
            this.p_list.Controls.Add(this.ListView_CircularDoublyLinkedList);
            this.p_list.Controls.Add(this.ListView_DoublyLinkedList);
            this.p_list.Controls.Add(this.label9);
            this.p_list.Controls.Add(this.label10);
            this.p_list.Controls.Add(this.ListView_CircularList);
            this.p_list.Controls.Add(this.ListView_SimpleList);
            this.p_list.Controls.Add(this.TexBox_Add_List);
            this.p_list.Controls.Add(this.Add_List);
            this.p_list.Controls.Add(this.label7);
            this.p_list.Controls.Add(this.label8);
            this.p_list.Location = new System.Drawing.Point(0, 0);
            this.p_list.Name = "p_list";
            this.p_list.Size = new System.Drawing.Size(707, 431);
            this.p_list.TabIndex = 34;
            this.p_list.Visible = false;
            // 
            // p_Tree
            // 
            this.p_Tree.BackColor = System.Drawing.SystemColors.Control;
            this.p_Tree.Controls.Add(this.p_Graph);
            this.p_Tree.Controls.Add(this.ListView_InOden);
            this.p_Tree.Controls.Add(this.ListView_PostOden);
            this.p_Tree.Controls.Add(this.ListView_PreOden);
            this.p_Tree.Controls.Add(this.label13);
            this.p_Tree.Controls.Add(this.label12);
            this.p_Tree.Controls.Add(this.label11);
            this.p_Tree.Controls.Add(this.TexBox_Search_BinaryTree);
            this.p_Tree.Controls.Add(this.Search_BinaryTree);
            this.p_Tree.Controls.Add(this.TexBox_Delete_BinaryTree);
            this.p_Tree.Controls.Add(this.Delete_BinaryTree);
            this.p_Tree.Controls.Add(this.TexBox_Add_BinaryTree);
            this.p_Tree.Controls.Add(this.Add_BinaryTree);
            this.p_Tree.Controls.Add(this.label6);
            this.p_Tree.Controls.Add(this.TreeView);
            this.p_Tree.Location = new System.Drawing.Point(0, 0);
            this.p_Tree.Name = "p_Tree";
            this.p_Tree.Size = new System.Drawing.Size(707, 431);
            this.p_Tree.TabIndex = 45;
            this.p_Tree.Visible = false;
            // 
            // p_Graph
            // 
            this.p_Graph.Controls.Add(this.p_Algorithm);
            this.p_Graph.Controls.Add(this.label15);
            this.p_Graph.Controls.Add(this.label14);
            this.p_Graph.Controls.Add(this.TextBox_Destination);
            this.p_Graph.Controls.Add(this.TextBox_Origin);
            this.p_Graph.Controls.Add(this.Add_Edge_Graph);
            this.p_Graph.Controls.Add(this.TextBox_Add_vertex);
            this.p_Graph.Controls.Add(this.Add_Vertex_Graph);
            this.p_Graph.Controls.Add(this.pictureBox1);
            this.p_Graph.Location = new System.Drawing.Point(611, 363);
            this.p_Graph.Name = "p_Graph";
            this.p_Graph.Size = new System.Drawing.Size(96, 68);
            this.p_Graph.TabIndex = 56;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(454, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 21);
            this.label15.TabIndex = 49;
            this.label15.Text = "Destination:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(459, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 21);
            this.label14.TabIndex = 48;
            this.label14.Text = "Origin:";
            // 
            // TextBox_Destination
            // 
            this.TextBox_Destination.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Destination.Location = new System.Drawing.Point(557, 158);
            this.TextBox_Destination.Name = "TextBox_Destination";
            this.TextBox_Destination.Size = new System.Drawing.Size(111, 28);
            this.TextBox_Destination.TabIndex = 47;
            // 
            // TextBox_Origin
            // 
            this.TextBox_Origin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Origin.Location = new System.Drawing.Point(557, 124);
            this.TextBox_Origin.Name = "TextBox_Origin";
            this.TextBox_Origin.Size = new System.Drawing.Size(111, 28);
            this.TextBox_Origin.TabIndex = 46;
            // 
            // Add_Edge_Graph
            // 
            this.Add_Edge_Graph.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Edge_Graph.Location = new System.Drawing.Point(557, 197);
            this.Add_Edge_Graph.Name = "Add_Edge_Graph";
            this.Add_Edge_Graph.Size = new System.Drawing.Size(111, 34);
            this.Add_Edge_Graph.TabIndex = 45;
            this.Add_Edge_Graph.Text = "Add Edge";
            this.Add_Edge_Graph.UseVisualStyleBackColor = true;
            this.Add_Edge_Graph.Click += new System.EventHandler(this.Add_Edge_Graph_Click);
            // 
            // TextBox_Add_vertex
            // 
            this.TextBox_Add_vertex.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Add_vertex.Location = new System.Drawing.Point(557, 50);
            this.TextBox_Add_vertex.Name = "TextBox_Add_vertex";
            this.TextBox_Add_vertex.Size = new System.Drawing.Size(111, 28);
            this.TextBox_Add_vertex.TabIndex = 44;
            // 
            // Add_Vertex_Graph
            // 
            this.Add_Vertex_Graph.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Vertex_Graph.Location = new System.Drawing.Point(557, 84);
            this.Add_Vertex_Graph.Name = "Add_Vertex_Graph";
            this.Add_Vertex_Graph.Size = new System.Drawing.Size(111, 34);
            this.Add_Vertex_Graph.TabIndex = 43;
            this.Add_Vertex_Graph.Text = "Add Vertex";
            this.Add_Vertex_Graph.UseVisualStyleBackColor = true;
            this.Add_Vertex_Graph.Click += new System.EventHandler(this.Add_Vertex_Graph_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 425);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ListView_InOden
            // 
            this.ListView_InOden.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_InOden.HideSelection = false;
            this.ListView_InOden.Location = new System.Drawing.Point(239, 320);
            this.ListView_InOden.Name = "ListView_InOden";
            this.ListView_InOden.Size = new System.Drawing.Size(296, 97);
            this.ListView_InOden.TabIndex = 55;
            this.ListView_InOden.UseCompatibleStateImageBehavior = false;
            // 
            // ListView_PostOden
            // 
            this.ListView_PostOden.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_PostOden.HideSelection = false;
            this.ListView_PostOden.Location = new System.Drawing.Point(236, 196);
            this.ListView_PostOden.Name = "ListView_PostOden";
            this.ListView_PostOden.Size = new System.Drawing.Size(299, 97);
            this.ListView_PostOden.TabIndex = 54;
            this.ListView_PostOden.UseCompatibleStateImageBehavior = false;
            // 
            // ListView_PreOden
            // 
            this.ListView_PreOden.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_PreOden.HideSelection = false;
            this.ListView_PreOden.Location = new System.Drawing.Point(236, 66);
            this.ListView_PreOden.Name = "ListView_PreOden";
            this.ListView_PreOden.Size = new System.Drawing.Size(298, 97);
            this.ListView_PreOden.TabIndex = 53;
            this.ListView_PreOden.UseCompatibleStateImageBehavior = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(235, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 21);
            this.label13.TabIndex = 52;
            this.label13.Text = "InOrden";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(235, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 21);
            this.label12.TabIndex = 51;
            this.label12.Text = "PostOrden";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(235, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 21);
            this.label11.TabIndex = 50;
            this.label11.Text = "PreOrden";
            // 
            // TexBox_Search_BinaryTree
            // 
            this.TexBox_Search_BinaryTree.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Search_BinaryTree.Location = new System.Drawing.Point(567, 214);
            this.TexBox_Search_BinaryTree.Name = "TexBox_Search_BinaryTree";
            this.TexBox_Search_BinaryTree.Size = new System.Drawing.Size(111, 28);
            this.TexBox_Search_BinaryTree.TabIndex = 46;
            // 
            // Search_BinaryTree
            // 
            this.Search_BinaryTree.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_BinaryTree.Location = new System.Drawing.Point(567, 248);
            this.Search_BinaryTree.Name = "Search_BinaryTree";
            this.Search_BinaryTree.Size = new System.Drawing.Size(111, 34);
            this.Search_BinaryTree.TabIndex = 45;
            this.Search_BinaryTree.Text = "Search";
            this.Search_BinaryTree.UseVisualStyleBackColor = true;
            this.Search_BinaryTree.Click += new System.EventHandler(this.Search_BinaryTree_Click);
            // 
            // TexBox_Delete_BinaryTree
            // 
            this.TexBox_Delete_BinaryTree.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Delete_BinaryTree.Location = new System.Drawing.Point(567, 140);
            this.TexBox_Delete_BinaryTree.Name = "TexBox_Delete_BinaryTree";
            this.TexBox_Delete_BinaryTree.Size = new System.Drawing.Size(111, 28);
            this.TexBox_Delete_BinaryTree.TabIndex = 44;
            // 
            // Delete_BinaryTree
            // 
            this.Delete_BinaryTree.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_BinaryTree.Location = new System.Drawing.Point(567, 174);
            this.Delete_BinaryTree.Name = "Delete_BinaryTree";
            this.Delete_BinaryTree.Size = new System.Drawing.Size(111, 34);
            this.Delete_BinaryTree.TabIndex = 43;
            this.Delete_BinaryTree.Text = "Delete";
            this.Delete_BinaryTree.UseVisualStyleBackColor = true;
            this.Delete_BinaryTree.Click += new System.EventHandler(this.Delete_BinaryTree_Click);
            // 
            // TexBox_Add_BinaryTree
            // 
            this.TexBox_Add_BinaryTree.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Add_BinaryTree.Location = new System.Drawing.Point(567, 66);
            this.TexBox_Add_BinaryTree.Name = "TexBox_Add_BinaryTree";
            this.TexBox_Add_BinaryTree.Size = new System.Drawing.Size(111, 28);
            this.TexBox_Add_BinaryTree.TabIndex = 42;
            // 
            // Add_BinaryTree
            // 
            this.Add_BinaryTree.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_BinaryTree.Location = new System.Drawing.Point(567, 100);
            this.Add_BinaryTree.Name = "Add_BinaryTree";
            this.Add_BinaryTree.Size = new System.Drawing.Size(111, 34);
            this.Add_BinaryTree.TabIndex = 41;
            this.Add_BinaryTree.Text = "Add";
            this.Add_BinaryTree.UseVisualStyleBackColor = true;
            this.Add_BinaryTree.Click += new System.EventHandler(this.Add_BinaryTree_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Binary Tree";
            // 
            // TreeView
            // 
            this.TreeView.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeView.Location = new System.Drawing.Point(13, 43);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(208, 388);
            this.TreeView.TabIndex = 0;
            // 
            // TexBox_Generate_List
            // 
            this.TexBox_Generate_List.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Generate_List.Location = new System.Drawing.Point(504, 217);
            this.TexBox_Generate_List.Name = "TexBox_Generate_List";
            this.TexBox_Generate_List.Size = new System.Drawing.Size(111, 28);
            this.TexBox_Generate_List.TabIndex = 44;
            // 
            // Generate_List
            // 
            this.Generate_List.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_List.Location = new System.Drawing.Point(504, 251);
            this.Generate_List.Name = "Generate_List";
            this.Generate_List.Size = new System.Drawing.Size(111, 34);
            this.Generate_List.TabIndex = 43;
            this.Generate_List.Text = "Generate";
            this.Generate_List.UseVisualStyleBackColor = true;
            this.Generate_List.Click += new System.EventHandler(this.Generate_List_Click);
            // 
            // TexBox_Delete_List
            // 
            this.TexBox_Delete_List.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Delete_List.Location = new System.Drawing.Point(557, 103);
            this.TexBox_Delete_List.Name = "TexBox_Delete_List";
            this.TexBox_Delete_List.Size = new System.Drawing.Size(111, 28);
            this.TexBox_Delete_List.TabIndex = 40;
            // 
            // Delete_List
            // 
            this.Delete_List.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_List.Location = new System.Drawing.Point(557, 137);
            this.Delete_List.Name = "Delete_List";
            this.Delete_List.Size = new System.Drawing.Size(111, 34);
            this.Delete_List.TabIndex = 39;
            this.Delete_List.Text = "Delete";
            this.Delete_List.UseVisualStyleBackColor = true;
            this.Delete_List.Click += new System.EventHandler(this.Delete_List_Click);
            // 
            // ListView_CircularDoublyLinkedList
            // 
            this.ListView_CircularDoublyLinkedList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_CircularDoublyLinkedList.FormattingEnabled = true;
            this.ListView_CircularDoublyLinkedList.ItemHeight = 21;
            this.ListView_CircularDoublyLinkedList.Location = new System.Drawing.Point(236, 40);
            this.ListView_CircularDoublyLinkedList.Name = "ListView_CircularDoublyLinkedList";
            this.ListView_CircularDoublyLinkedList.Size = new System.Drawing.Size(164, 172);
            this.ListView_CircularDoublyLinkedList.TabIndex = 38;
            // 
            // ListView_DoublyLinkedList
            // 
            this.ListView_DoublyLinkedList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_DoublyLinkedList.FormattingEnabled = true;
            this.ListView_DoublyLinkedList.ItemHeight = 21;
            this.ListView_DoublyLinkedList.Location = new System.Drawing.Point(236, 240);
            this.ListView_DoublyLinkedList.Name = "ListView_DoublyLinkedList";
            this.ListView_DoublyLinkedList.Size = new System.Drawing.Size(164, 172);
            this.ListView_DoublyLinkedList.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(218, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "Circular DoublyLinked List";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(232, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 21);
            this.label10.TabIndex = 35;
            this.label10.Text = "Doubly Linkde List";
            // 
            // ListView_CircularList
            // 
            this.ListView_CircularList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_CircularList.FormattingEnabled = true;
            this.ListView_CircularList.ItemHeight = 21;
            this.ListView_CircularList.Location = new System.Drawing.Point(13, 240);
            this.ListView_CircularList.Name = "ListView_CircularList";
            this.ListView_CircularList.Size = new System.Drawing.Size(164, 172);
            this.ListView_CircularList.TabIndex = 34;
            // 
            // ListView_SimpleList
            // 
            this.ListView_SimpleList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_SimpleList.FormattingEnabled = true;
            this.ListView_SimpleList.ItemHeight = 21;
            this.ListView_SimpleList.Location = new System.Drawing.Point(13, 40);
            this.ListView_SimpleList.Name = "ListView_SimpleList";
            this.ListView_SimpleList.Size = new System.Drawing.Size(164, 172);
            this.ListView_SimpleList.TabIndex = 28;
            // 
            // TexBox_Add_List
            // 
            this.TexBox_Add_List.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Add_List.Location = new System.Drawing.Point(440, 103);
            this.TexBox_Add_List.Name = "TexBox_Add_List";
            this.TexBox_Add_List.Size = new System.Drawing.Size(111, 28);
            this.TexBox_Add_List.TabIndex = 27;
            // 
            // Add_List
            // 
            this.Add_List.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_List.Location = new System.Drawing.Point(440, 137);
            this.Add_List.Name = "Add_List";
            this.Add_List.Size = new System.Drawing.Size(111, 34);
            this.Add_List.TabIndex = 24;
            this.Add_List.Text = "Add";
            this.Add_List.UseVisualStyleBackColor = true;
            this.Add_List.Click += new System.EventHandler(this.Add_List_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Circular List";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Simple List";
            // 
            // TexBox_Enqueue_PriorityQueue
            // 
            this.TexBox_Enqueue_PriorityQueue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Enqueue_PriorityQueue.Location = new System.Drawing.Point(557, 172);
            this.TexBox_Enqueue_PriorityQueue.Name = "TexBox_Enqueue_PriorityQueue";
            this.TexBox_Enqueue_PriorityQueue.Size = new System.Drawing.Size(147, 28);
            this.TexBox_Enqueue_PriorityQueue.TabIndex = 33;
            // 
            // Priority_Queue
            // 
            this.Priority_Queue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority_Queue.Location = new System.Drawing.Point(557, 206);
            this.Priority_Queue.Name = "Priority_Queue";
            this.Priority_Queue.Size = new System.Drawing.Size(147, 39);
            this.Priority_Queue.TabIndex = 32;
            this.Priority_Queue.Text = "Priority";
            this.Priority_Queue.UseVisualStyleBackColor = true;
            this.Priority_Queue.Click += new System.EventHandler(this.Priority_Queue_Click);
            // 
            // ListView_PriorityQueue
            // 
            this.ListView_PriorityQueue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_PriorityQueue.FormattingEnabled = true;
            this.ListView_PriorityQueue.ItemHeight = 21;
            this.ListView_PriorityQueue.Location = new System.Drawing.Point(353, 46);
            this.ListView_PriorityQueue.Name = "ListView_PriorityQueue";
            this.ListView_PriorityQueue.Size = new System.Drawing.Size(164, 382);
            this.ListView_PriorityQueue.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Priority Queue";
            // 
            // ListView_CircularQueue
            // 
            this.ListView_CircularQueue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_CircularQueue.FormattingEnabled = true;
            this.ListView_CircularQueue.ItemHeight = 21;
            this.ListView_CircularQueue.Location = new System.Drawing.Point(183, 46);
            this.ListView_CircularQueue.Name = "ListView_CircularQueue";
            this.ListView_CircularQueue.Size = new System.Drawing.Size(164, 382);
            this.ListView_CircularQueue.TabIndex = 29;
            // 
            // ListView_Queue
            // 
            this.ListView_Queue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_Queue.FormattingEnabled = true;
            this.ListView_Queue.ItemHeight = 21;
            this.ListView_Queue.Location = new System.Drawing.Point(13, 46);
            this.ListView_Queue.Name = "ListView_Queue";
            this.ListView_Queue.Size = new System.Drawing.Size(164, 382);
            this.ListView_Queue.TabIndex = 28;
            // 
            // TexBox_Enqueue_Queue
            // 
            this.TexBox_Enqueue_Queue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Enqueue_Queue.Location = new System.Drawing.Point(557, 45);
            this.TexBox_Enqueue_Queue.Name = "TexBox_Enqueue_Queue";
            this.TexBox_Enqueue_Queue.Size = new System.Drawing.Size(147, 28);
            this.TexBox_Enqueue_Queue.TabIndex = 27;
            // 
            // Dequeue_Queue
            // 
            this.Dequeue_Queue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dequeue_Queue.Location = new System.Drawing.Point(557, 127);
            this.Dequeue_Queue.Name = "Dequeue_Queue";
            this.Dequeue_Queue.Size = new System.Drawing.Size(147, 39);
            this.Dequeue_Queue.TabIndex = 25;
            this.Dequeue_Queue.Text = "Dequeue";
            this.Dequeue_Queue.UseVisualStyleBackColor = true;
            this.Dequeue_Queue.Click += new System.EventHandler(this.Dequeue_Queue_Click);
            // 
            // Enqueue_Queue
            // 
            this.Enqueue_Queue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enqueue_Queue.Location = new System.Drawing.Point(557, 79);
            this.Enqueue_Queue.Name = "Enqueue_Queue";
            this.Enqueue_Queue.Size = new System.Drawing.Size(147, 39);
            this.Enqueue_Queue.TabIndex = 24;
            this.Enqueue_Queue.Text = "Enqueue";
            this.Enqueue_Queue.UseVisualStyleBackColor = true;
            this.Enqueue_Queue.Click += new System.EventHandler(this.Enqueue_Queue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Circular Queue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Queue";
            // 
            // p_Algorithm
            // 
            this.p_Algorithm.Controls.Add(this.Show_Algorithm);
            this.p_Algorithm.Controls.Add(this.label17);
            this.p_Algorithm.Controls.Add(this.Case_Algorithm);
            this.p_Algorithm.Controls.Add(this.label16);
            this.p_Algorithm.Controls.Add(this.TextBox_Size_Array);
            this.p_Algorithm.Controls.Add(this.Textbox_Algorithm);
            this.p_Algorithm.Controls.Add(this.Generate_Array);
            this.p_Algorithm.Location = new System.Drawing.Point(615, 395);
            this.p_Algorithm.Name = "p_Algorithm";
            this.p_Algorithm.Size = new System.Drawing.Size(92, 36);
            this.p_Algorithm.TabIndex = 50;
            // 
            // Show_Algorithm
            // 
            this.Show_Algorithm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Algorithm.Location = new System.Drawing.Point(122, 209);
            this.Show_Algorithm.Name = "Show_Algorithm";
            this.Show_Algorithm.Size = new System.Drawing.Size(91, 32);
            this.Show_Algorithm.TabIndex = 6;
            this.Show_Algorithm.Text = "Show";
            this.Show_Algorithm.UseVisualStyleBackColor = true;
            this.Show_Algorithm.Click += new System.EventHandler(this.Show_Algorithm_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 25);
            this.label17.TabIndex = 5;
            this.label17.Text = "Algorithm:";
            // 
            // Case_Algorithm
            // 
            this.Case_Algorithm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case_Algorithm.FormattingEnabled = true;
            this.Case_Algorithm.Items.AddRange(new object[] {
            "BubbleSort",
            "Cocktailsort",
            "Insertionsort",
            "BucketSort",
            "Countingsort",
            "Mergesort",
            "Binarytreesort",
            "Pigeonhole",
            "Radixsort",
            "Gnomesort",
            "Shellsort",
            "Combsort",
            "Selectionsort",
            "Heapsort",
            "QuickSort"});
            this.Case_Algorithm.Location = new System.Drawing.Point(121, 169);
            this.Case_Algorithm.Name = "Case_Algorithm";
            this.Case_Algorithm.Size = new System.Drawing.Size(121, 29);
            this.Case_Algorithm.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(62, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 25);
            this.label16.TabIndex = 3;
            this.label16.Text = "Size:";
            // 
            // TextBox_Size_Array
            // 
            this.TextBox_Size_Array.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Size_Array.Location = new System.Drawing.Point(121, 98);
            this.TextBox_Size_Array.Name = "TextBox_Size_Array";
            this.TextBox_Size_Array.Size = new System.Drawing.Size(100, 28);
            this.TextBox_Size_Array.TabIndex = 2;
            // 
            // Textbox_Algorithm
            // 
            this.Textbox_Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Algorithm.Location = new System.Drawing.Point(258, 16);
            this.Textbox_Algorithm.Multiline = true;
            this.Textbox_Algorithm.Name = "Textbox_Algorithm";
            this.Textbox_Algorithm.ReadOnly = true;
            this.Textbox_Algorithm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Textbox_Algorithm.Size = new System.Drawing.Size(433, 401);
            this.Textbox_Algorithm.TabIndex = 1;
            // 
            // Generate_Array
            // 
            this.Generate_Array.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_Array.Location = new System.Drawing.Point(122, 132);
            this.Generate_Array.Name = "Generate_Array";
            this.Generate_Array.Size = new System.Drawing.Size(91, 32);
            this.Generate_Array.TabIndex = 0;
            this.Generate_Array.Text = "generator";
            this.Generate_Array.UseVisualStyleBackColor = true;
            this.Generate_Array.Click += new System.EventHandler(this.Generate_Array_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 490);
            this.Controls.Add(this.p_queue);
            this.Controls.Add(this.ListView_StackD);
            this.Controls.Add(this.ListView_StackS);
            this.Controls.Add(this.TexBox_Push_Stack);
            this.Controls.Add(this.Peek_Stack);
            this.Controls.Add(this.Pop_Stack);
            this.Controls.Add(this.Push_Stack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.p_queue.ResumeLayout(false);
            this.p_queue.PerformLayout();
            this.p_list.ResumeLayout(false);
            this.p_list.PerformLayout();
            this.p_Tree.ResumeLayout(false);
            this.p_Tree.PerformLayout();
            this.p_Graph.ResumeLayout(false);
            this.p_Graph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p_Algorithm.ResumeLayout(false);
            this.p_Algorithm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StackMenu;
        private System.Windows.Forms.ToolStripMenuItem QueueMenu;
        private System.Windows.Forms.ToolStripMenuItem ListMenu;
        private System.Windows.Forms.ToolStripMenuItem TreeMenu;
        private System.Windows.Forms.ToolStripMenuItem GraphMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Peek_Stack;
        private System.Windows.Forms.Button Pop_Stack;
        private System.Windows.Forms.Button Push_Stack;
        private System.Windows.Forms.TextBox TexBox_Push_Stack;
        private System.Windows.Forms.ListBox ListView_StackS;
        private System.Windows.Forms.ListBox ListView_StackD;
        private System.Windows.Forms.Panel p_queue;
        private System.Windows.Forms.ListBox ListView_CircularQueue;
        private System.Windows.Forms.ListBox ListView_Queue;
        private System.Windows.Forms.TextBox TexBox_Enqueue_Queue;
        private System.Windows.Forms.Button Dequeue_Queue;
        private System.Windows.Forms.Button Enqueue_Queue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ListView_PriorityQueue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TexBox_Enqueue_PriorityQueue;
        private System.Windows.Forms.Button Priority_Queue;
        private System.Windows.Forms.Panel p_list;
        private System.Windows.Forms.ListBox ListView_CircularDoublyLinkedList;
        private System.Windows.Forms.ListBox ListView_DoublyLinkedList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox ListView_CircularList;
        private System.Windows.Forms.ListBox ListView_SimpleList;
        private System.Windows.Forms.TextBox TexBox_Add_List;
        private System.Windows.Forms.Button Add_List;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TexBox_Generate_List;
        private System.Windows.Forms.Button Generate_List;
        private System.Windows.Forms.TextBox TexBox_Delete_List;
        private System.Windows.Forms.Button Delete_List;
        private System.Windows.Forms.Panel p_Tree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.TextBox TexBox_Delete_BinaryTree;
        private System.Windows.Forms.Button Delete_BinaryTree;
        private System.Windows.Forms.TextBox TexBox_Add_BinaryTree;
        private System.Windows.Forms.Button Add_BinaryTree;
        private System.Windows.Forms.TextBox TexBox_Search_BinaryTree;
        private System.Windows.Forms.Button Search_BinaryTree;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView ListView_InOden;
        private System.Windows.Forms.ListView ListView_PostOden;
        private System.Windows.Forms.ListView ListView_PreOden;
        private System.Windows.Forms.Panel p_Graph;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextBox_Destination;
        private System.Windows.Forms.TextBox TextBox_Origin;
        private System.Windows.Forms.Button Add_Edge_Graph;
        private System.Windows.Forms.TextBox TextBox_Add_vertex;
        private System.Windows.Forms.Button Add_Vertex_Graph;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem AlgorithmMenu;
        private System.Windows.Forms.Panel p_Algorithm;
        private System.Windows.Forms.Button Generate_Array;
        private System.Windows.Forms.TextBox Textbox_Algorithm;
        private System.Windows.Forms.TextBox TextBox_Size_Array;
        private System.Windows.Forms.Button Show_Algorithm;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox Case_Algorithm;
        private System.Windows.Forms.Label label16;
    }
}

