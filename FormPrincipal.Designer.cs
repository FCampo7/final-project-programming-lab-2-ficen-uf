namespace TP_labo_programacion_II
{
    partial class FormPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.parte3Boton = new System.Windows.Forms.Button();
            this.problemaLBoton = new System.Windows.Forms.Button();
            this.viajanteBoton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.parte3Boton);
            this.panel1.Controls.Add(this.problemaLBoton);
            this.panel1.Controls.Add(this.viajanteBoton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 156);
            this.panel1.TabIndex = 0;
            // 
            // parte3Boton
            // 
            this.parte3Boton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parte3Boton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.parte3Boton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.parte3Boton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.parte3Boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parte3Boton.ForeColor = System.Drawing.Color.White;
            this.parte3Boton.Location = new System.Drawing.Point(3, 105);
            this.parte3Boton.Name = "parte3Boton";
            this.parte3Boton.Size = new System.Drawing.Size(301, 45);
            this.parte3Boton.TabIndex = 5;
            this.parte3Boton.Text = "Parte III";
            this.parte3Boton.UseVisualStyleBackColor = false;
            this.parte3Boton.Click += new System.EventHandler(this.parte3Boton_Click);
            // 
            // problemaLBoton
            // 
            this.problemaLBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.problemaLBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.problemaLBoton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.problemaLBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.problemaLBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.problemaLBoton.ForeColor = System.Drawing.Color.White;
            this.problemaLBoton.Location = new System.Drawing.Point(3, 55);
            this.problemaLBoton.Name = "problemaLBoton";
            this.problemaLBoton.Size = new System.Drawing.Size(301, 45);
            this.problemaLBoton.TabIndex = 4;
            this.problemaLBoton.Text = "Problema de la L";
            this.problemaLBoton.UseVisualStyleBackColor = false;
            this.problemaLBoton.Click += new System.EventHandler(this.problemaLBoton_Click);
            // 
            // viajanteBoton
            // 
            this.viajanteBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viajanteBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.viajanteBoton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.viajanteBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.viajanteBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viajanteBoton.ForeColor = System.Drawing.Color.White;
            this.viajanteBoton.Location = new System.Drawing.Point(3, 5);
            this.viajanteBoton.Name = "viajanteBoton";
            this.viajanteBoton.Size = new System.Drawing.Size(301, 45);
            this.viajanteBoton.TabIndex = 3;
            this.viajanteBoton.Text = "Problema del viajante";
            this.viajanteBoton.UseVisualStyleBackColor = false;
            this.viajanteBoton.Click += new System.EventHandler(this.viajanteBoton_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(307, 186);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP labo de programacion II";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button parte3Boton;
        private System.Windows.Forms.Button problemaLBoton;
        private System.Windows.Forms.Button viajanteBoton;
    }
}

