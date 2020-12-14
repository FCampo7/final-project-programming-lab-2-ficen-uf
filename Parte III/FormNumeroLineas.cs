using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte_3_del_TP_de_LPII
{
    public partial class FormNumeroLineas : Form // Formulario que se utiliza para cargar el número de filas del archivo a leer.
    {
        private int numeroDeFilas;

        public FormNumeroLineas() {
            InitializeComponent();
            numeroDeFilas=0;
        }

        public int getNumeroDeFilas() { // Función para obtener desde el formulario principal el número de filas que queremos cargar.
            return this.numeroDeFilas;
        }

        private void cancelarBoton_Click(object sender, EventArgs e) {
            this.DialogResult=DialogResult.Cancel;
            this.Close();
        }

        private void aceptarBoton_Click(object sender, EventArgs e) { // Guardamos el número de filas al clickear aceptar.
            numeroDeFilas=Convert.ToInt32(nFilasNUD.Value);
            this.DialogResult=DialogResult.OK;
            this.Close();
        }
    }
}
