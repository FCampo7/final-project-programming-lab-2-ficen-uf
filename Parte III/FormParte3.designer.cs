namespace Parte_3_del_TP_de_LPII
{
    partial class FormParte3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParte3));
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.InsertSortBoton = new System.Windows.Forms.Button();
            this.MergeSortBoton = new System.Windows.Forms.Button();
            this.quickSortBoton = new System.Windows.Forms.Button();
            this.burbujaContBoton = new System.Windows.Forms.Button();
            this.burbujaBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaDesordenadaBoton = new System.Windows.Forms.Button();
            this.cambiarNumeroFilasBoton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.openFileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openFileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.openFileButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.openFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileButton.ForeColor = System.Drawing.Color.White;
            this.openFileButton.Location = new System.Drawing.Point(0, 0);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(179, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Abrir archivo";
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 511);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tp Parte 3";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.InsertSortBoton);
            this.splitContainer1.Panel2.Controls.Add(this.MergeSortBoton);
            this.splitContainer1.Panel2.Controls.Add(this.quickSortBoton);
            this.splitContainer1.Panel2.Controls.Add(this.burbujaContBoton);
            this.splitContainer1.Panel2.Controls.Add(this.burbujaBoton);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.ListaDesordenadaBoton);
            this.splitContainer1.Panel2.Controls.Add(this.cambiarNumeroFilasBoton);
            this.splitContainer1.Panel2.Controls.Add(this.openFileButton);
            this.splitContainer1.Size = new System.Drawing.Size(690, 479);
            this.splitContainer1.SplitterDistance = 507;
            this.splitContainer1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(507, 479);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Todos los métodos ordenan por ID";
            // 
            // InsertSortBoton
            // 
            this.InsertSortBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.InsertSortBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertSortBoton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.InsertSortBoton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InsertSortBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.InsertSortBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertSortBoton.ForeColor = System.Drawing.Color.White;
            this.InsertSortBoton.Location = new System.Drawing.Point(0, 174);
            this.InsertSortBoton.Name = "InsertSortBoton";
            this.InsertSortBoton.Size = new System.Drawing.Size(179, 23);
            this.InsertSortBoton.TabIndex = 19;
            this.InsertSortBoton.Text = "InsertSort";
            this.toolTip1.SetToolTip(this.InsertSortBoton, "Este es uno de los métodos más sencillos. Consta de tomar uno por uno los element" +
        "os de un arreglo y recorrerlo hacia su posición con respecto a los anteriormente" +
        " ordenados.");
            this.InsertSortBoton.UseVisualStyleBackColor = false;
            this.InsertSortBoton.Click += new System.EventHandler(this.InsertSortBoton_Click);
            // 
            // MergeSortBoton
            // 
            this.MergeSortBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.MergeSortBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MergeSortBoton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.MergeSortBoton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MergeSortBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.MergeSortBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MergeSortBoton.ForeColor = System.Drawing.Color.White;
            this.MergeSortBoton.Location = new System.Drawing.Point(0, 151);
            this.MergeSortBoton.Name = "MergeSortBoton";
            this.MergeSortBoton.Size = new System.Drawing.Size(179, 23);
            this.MergeSortBoton.TabIndex = 18;
            this.MergeSortBoton.Text = "MergeSort";
            this.toolTip1.SetToolTip(this.MergeSortBoton, "Es un algoritmo de ordenamiento externo estable basado en la técnica divide y ven" +
        "cerás. Es de complejidad O(n log n).");
            this.MergeSortBoton.UseVisualStyleBackColor = false;
            this.MergeSortBoton.Click += new System.EventHandler(this.MergeSortBoton_Click);
            // 
            // quickSortBoton
            // 
            this.quickSortBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.quickSortBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.quickSortBoton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.quickSortBoton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.quickSortBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.quickSortBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quickSortBoton.ForeColor = System.Drawing.Color.White;
            this.quickSortBoton.Location = new System.Drawing.Point(0, 128);
            this.quickSortBoton.Name = "quickSortBoton";
            this.quickSortBoton.Size = new System.Drawing.Size(179, 23);
            this.quickSortBoton.TabIndex = 17;
            this.quickSortBoton.Text = "QuickSort";
            this.toolTip1.SetToolTip(this.quickSortBoton, "Es un algoritmo basado en la técnica de divide y vencerás, que permite, en promed" +
        "io, ordenar n elementos en un tiempo proporcional a n log n.");
            this.quickSortBoton.UseVisualStyleBackColor = false;
            this.quickSortBoton.Click += new System.EventHandler(this.quickSortBoton_Click);
            // 
            // burbujaContBoton
            // 
            this.burbujaContBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.burbujaContBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.burbujaContBoton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.burbujaContBoton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.burbujaContBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.burbujaContBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.burbujaContBoton.ForeColor = System.Drawing.Color.White;
            this.burbujaContBoton.Location = new System.Drawing.Point(0, 105);
            this.burbujaContBoton.Name = "burbujaContBoton";
            this.burbujaContBoton.Size = new System.Drawing.Size(179, 23);
            this.burbujaContBoton.TabIndex = 16;
            this.burbujaContBoton.Text = "Burbuja Contador";
            this.toolTip1.SetToolTip(this.burbujaContBoton, resources.GetString("burbujaContBoton.ToolTip"));
            this.burbujaContBoton.UseVisualStyleBackColor = false;
            this.burbujaContBoton.Click += new System.EventHandler(this.burbujaContBoton_Click);
            // 
            // burbujaBoton
            // 
            this.burbujaBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.burbujaBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.burbujaBoton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.burbujaBoton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.burbujaBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.burbujaBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.burbujaBoton.ForeColor = System.Drawing.Color.White;
            this.burbujaBoton.Location = new System.Drawing.Point(0, 82);
            this.burbujaBoton.Name = "burbujaBoton";
            this.burbujaBoton.Size = new System.Drawing.Size(179, 23);
            this.burbujaBoton.TabIndex = 15;
            this.burbujaBoton.Text = "Burbuja";
            this.toolTip1.SetToolTip(this.burbujaBoton, "Es un sencillo algoritmo de ordenamiento.\r\nFunciona revisando cada elemento de la" +
        " lista que va a ser ordenada con el siguiente, intercambiándolos de posición si " +
        "están en el orden equivocado.");
            this.burbujaBoton.UseVisualStyleBackColor = false;
            this.burbujaBoton.Click += new System.EventHandler(this.burbujaBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Métodos Sort";
            // 
            // ListaDesordenadaBoton
            // 
            this.ListaDesordenadaBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.ListaDesordenadaBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListaDesordenadaBoton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.ListaDesordenadaBoton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListaDesordenadaBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.ListaDesordenadaBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListaDesordenadaBoton.ForeColor = System.Drawing.Color.White;
            this.ListaDesordenadaBoton.Location = new System.Drawing.Point(0, 46);
            this.ListaDesordenadaBoton.Name = "ListaDesordenadaBoton";
            this.ListaDesordenadaBoton.Size = new System.Drawing.Size(179, 23);
            this.ListaDesordenadaBoton.TabIndex = 2;
            this.ListaDesordenadaBoton.Text = "Lista desordenada";
            this.ListaDesordenadaBoton.UseVisualStyleBackColor = false;
            this.ListaDesordenadaBoton.Click += new System.EventHandler(this.ListaDesordenadaBoton_Click);
            // 
            // cambiarNumeroFilasBoton
            // 
            this.cambiarNumeroFilasBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cambiarNumeroFilasBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cambiarNumeroFilasBoton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cambiarNumeroFilasBoton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cambiarNumeroFilasBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cambiarNumeroFilasBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambiarNumeroFilasBoton.ForeColor = System.Drawing.Color.White;
            this.cambiarNumeroFilasBoton.Location = new System.Drawing.Point(0, 23);
            this.cambiarNumeroFilasBoton.Name = "cambiarNumeroFilasBoton";
            this.cambiarNumeroFilasBoton.Size = new System.Drawing.Size(179, 23);
            this.cambiarNumeroFilasBoton.TabIndex = 1;
            this.cambiarNumeroFilasBoton.Text = "Cambiar Número de Filas";
            this.cambiarNumeroFilasBoton.UseVisualStyleBackColor = false;
            this.cambiarNumeroFilasBoton.Click += new System.EventHandler(this.cambiarNumeroFilasBoton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // FormParte3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(704, 511);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormParte3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tp parte III";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormParte3_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button cambiarNumeroFilasBoton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InsertSortBoton;
        private System.Windows.Forms.Button MergeSortBoton;
        private System.Windows.Forms.Button quickSortBoton;
        private System.Windows.Forms.Button burbujaContBoton;
        private System.Windows.Forms.Button burbujaBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ListaDesordenadaBoton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

