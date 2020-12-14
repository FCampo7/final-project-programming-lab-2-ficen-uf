using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP_labo_programacion_II
{
    public partial class FormPrincipal : Form
    {
        Form fpv; // Formulario problema del viajante.
        Form fpl; // Formulario problema de la L.
        Form fp3; // Formulario parte 3 del TP.

        TitleBar titlebar;

        public FormPrincipal() {
            InitializeComponent();
            titlebar = new TitleBar(this, "TP Labo Programación II");
            this.Controls.Add(titlebar);
        }

        // Al apretar los botones se esconde el formulario principal y se muestra el seleccionado.
        private void viajanteBoton_Click(object sender, EventArgs e) {
            fpv = new Problema_del_Viajante.FormViajante(this);
            this.Hide();
            fpv.Show();
        }

        private void problemaLBoton_Click(object sender, EventArgs e) {
            fpl = new Problema_de_la_L.FormPL(this);
            this.Hide();
            fpl.Show();
        }

        private void parte3Boton_Click(object sender, EventArgs e) {
            fp3 = new Parte_3_del_TP_de_LPII.FormParte3(this);
            this.Hide();
            fp3.Show();
        }
    }
}
