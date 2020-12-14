namespace Problema_del_Viajante
{
    partial class FormViajante
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listCiudades = new System.Windows.Forms.ListView();
            this.columnasNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaPosX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnasPosY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreCiudad = new System.Windows.Forms.TextBox();
            this.posicionX = new System.Windows.Forms.NumericUpDown();
            this.labelDistTotal = new System.Windows.Forms.Label();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.labelPosX = new System.Windows.Forms.Label();
            this.posicionY = new System.Windows.Forms.NumericUpDown();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPosY = new System.Windows.Forms.Label();
            this.botonResolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posicionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionY)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listCiudades);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.nombreCiudad);
            this.splitContainer1.Panel2.Controls.Add(this.posicionX);
            this.splitContainer1.Panel2.Controls.Add(this.labelDistTotal);
            this.splitContainer1.Panel2.Controls.Add(this.botonAgregar);
            this.splitContainer1.Panel2.Controls.Add(this.labelPosX);
            this.splitContainer1.Panel2.Controls.Add(this.posicionY);
            this.splitContainer1.Panel2.Controls.Add(this.botonLimpiar);
            this.splitContainer1.Panel2.Controls.Add(this.labelNombre);
            this.splitContainer1.Panel2.Controls.Add(this.labelPosY);
            this.splitContainer1.Panel2.Controls.Add(this.botonResolver);
            this.splitContainer1.Size = new System.Drawing.Size(704, 511);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 12;
            this.splitContainer1.TabStop = false;
            // 
            // listCiudades
            // 
            this.listCiudades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.listCiudades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnasNombre,
            this.columnaPosX,
            this.columnasPosY});
            this.listCiudades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCiudades.ForeColor = System.Drawing.Color.White;
            this.listCiudades.FullRowSelect = true;
            this.listCiudades.GridLines = true;
            this.listCiudades.HideSelection = false;
            this.listCiudades.Location = new System.Drawing.Point(0, 0);
            this.listCiudades.Name = "listCiudades";
            this.listCiudades.Size = new System.Drawing.Size(500, 511);
            this.listCiudades.TabIndex = 23;
            this.listCiudades.TabStop = false;
            this.listCiudades.UseCompatibleStateImageBehavior = false;
            this.listCiudades.View = System.Windows.Forms.View.Details;
            // 
            // columnasNombre
            // 
            this.columnasNombre.Text = "Nombre";
            this.columnasNombre.Width = 62;
            // 
            // columnaPosX
            // 
            this.columnaPosX.Text = "Posición X";
            this.columnaPosX.Width = 62;
            // 
            // columnasPosY
            // 
            this.columnasPosY.Text = "Posición Y";
            this.columnasPosY.Width = 62;
            // 
            // nombreCiudad
            // 
            this.nombreCiudad.Location = new System.Drawing.Point(74, 6);
            this.nombreCiudad.Name = "nombreCiudad";
            this.nombreCiudad.Size = new System.Drawing.Size(122, 20);
            this.nombreCiudad.TabIndex = 0;
            // 
            // posicionX
            // 
            this.posicionX.Location = new System.Drawing.Point(76, 31);
            this.posicionX.Name = "posicionX";
            this.posicionX.Size = new System.Drawing.Size(120, 20);
            this.posicionX.TabIndex = 1;
            // 
            // labelDistTotal
            // 
            this.labelDistTotal.AutoSize = true;
            this.labelDistTotal.ForeColor = System.Drawing.Color.White;
            this.labelDistTotal.Location = new System.Drawing.Point(10, 89);
            this.labelDistTotal.Name = "labelDistTotal";
            this.labelDistTotal.Size = new System.Drawing.Size(86, 13);
            this.labelDistTotal.TabIndex = 33;
            this.labelDistTotal.Text = "Distancia total: 0";
            // 
            // botonAgregar
            // 
            this.botonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.botonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.botonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.botonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregar.ForeColor = System.Drawing.Color.White;
            this.botonAgregar.Location = new System.Drawing.Point(13, 116);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(183, 23);
            this.botonAgregar.TabIndex = 3;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // labelPosX
            // 
            this.labelPosX.AutoSize = true;
            this.labelPosX.ForeColor = System.Drawing.Color.White;
            this.labelPosX.Location = new System.Drawing.Point(10, 35);
            this.labelPosX.Name = "labelPosX";
            this.labelPosX.Size = new System.Drawing.Size(60, 13);
            this.labelPosX.TabIndex = 25;
            this.labelPosX.Text = "Posición X:";
            // 
            // posicionY
            // 
            this.posicionY.Location = new System.Drawing.Point(76, 57);
            this.posicionY.Name = "posicionY";
            this.posicionY.Size = new System.Drawing.Size(120, 20);
            this.posicionY.TabIndex = 2;
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.botonLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.botonLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.botonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonLimpiar.ForeColor = System.Drawing.Color.White;
            this.botonLimpiar.Location = new System.Drawing.Point(13, 174);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(183, 23);
            this.botonLimpiar.TabIndex = 5;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = false;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(10, 10);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 32;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelPosY
            // 
            this.labelPosY.AutoSize = true;
            this.labelPosY.ForeColor = System.Drawing.Color.White;
            this.labelPosY.Location = new System.Drawing.Point(10, 61);
            this.labelPosY.Name = "labelPosY";
            this.labelPosY.Size = new System.Drawing.Size(60, 13);
            this.labelPosY.TabIndex = 26;
            this.labelPosY.Text = "Posición Y:";
            // 
            // botonResolver
            // 
            this.botonResolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.botonResolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.botonResolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.botonResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonResolver.ForeColor = System.Drawing.Color.White;
            this.botonResolver.Location = new System.Drawing.Point(13, 145);
            this.botonResolver.Name = "botonResolver";
            this.botonResolver.Size = new System.Drawing.Size(183, 23);
            this.botonResolver.TabIndex = 4;
            this.botonResolver.Text = "Resolver";
            this.botonResolver.UseVisualStyleBackColor = false;
            this.botonResolver.Click += new System.EventHandler(this.botonResolver_Click);
            // 
            // FormViajante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(704, 511);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormViajante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problema del viajante";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViajante_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.posicionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listCiudades;
        private System.Windows.Forms.ColumnHeader columnasNombre;
        private System.Windows.Forms.ColumnHeader columnaPosX;
        private System.Windows.Forms.ColumnHeader columnasPosY;
        private System.Windows.Forms.TextBox nombreCiudad;
        private System.Windows.Forms.NumericUpDown posicionX;
        private System.Windows.Forms.Label labelDistTotal;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label labelPosX;
        private System.Windows.Forms.NumericUpDown posicionY;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPosY;
        private System.Windows.Forms.Button botonResolver;
    }
}

