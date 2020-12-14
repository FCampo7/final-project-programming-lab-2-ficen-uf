namespace Parte_3_del_TP_de_LPII
{
    partial class FormNumeroLineas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelarBoton = new System.Windows.Forms.Button();
            this.aceptarBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nFilasNUD = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFilasNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelarBoton);
            this.panel1.Controls.Add(this.aceptarBoton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nFilasNUD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 71);
            this.panel1.TabIndex = 0;
            // 
            // cancelarBoton
            // 
            this.cancelarBoton.Location = new System.Drawing.Point(128, 37);
            this.cancelarBoton.Name = "cancelarBoton";
            this.cancelarBoton.Size = new System.Drawing.Size(120, 23);
            this.cancelarBoton.TabIndex = 3;
            this.cancelarBoton.Text = "Cancelar";
            this.cancelarBoton.UseVisualStyleBackColor = true;
            this.cancelarBoton.Click += new System.EventHandler(this.cancelarBoton_Click);
            // 
            // aceptarBoton
            // 
            this.aceptarBoton.Location = new System.Drawing.Point(16, 37);
            this.aceptarBoton.Name = "aceptarBoton";
            this.aceptarBoton.Size = new System.Drawing.Size(106, 23);
            this.aceptarBoton.TabIndex = 2;
            this.aceptarBoton.Text = "Aceptar";
            this.aceptarBoton.UseVisualStyleBackColor = true;
            this.aceptarBoton.Click += new System.EventHandler(this.aceptarBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de filas a leer";
            // 
            // nFilasNUD
            // 
            this.nFilasNUD.Location = new System.Drawing.Point(128, 11);
            this.nFilasNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nFilasNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFilasNUD.Name = "nFilasNUD";
            this.nFilasNUD.Size = new System.Drawing.Size(120, 20);
            this.nFilasNUD.TabIndex = 0;
            this.nFilasNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormNumeroLineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 71);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormNumeroLineas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Número de filas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFilasNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelarBoton;
        private System.Windows.Forms.Button aceptarBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nFilasNUD;
    }
}