using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace Parte_3_del_TP_de_LPII
{
    public struct sFila // Estructura que usaremos para almacenar los datos.
    {
        public string A; // Columnas A, B, C y D del archivo.
        public string B;
        public string C;
        public string D;
        public sFila(string A, string B, string C, string D) {
            this.A=A;
            this.B=B;
            this.C=C;
            this.D=D;
        }
    }

    public partial class FormParte3 : Form
    {
        private int numeroDeFilas; // Número de filas que queremos leer del archivo.
        private cOrdenador Ordenador = new cOrdenador(); // Clase que hicimos que contiene los algoritmos Sort.
        private string fileName; // Nombre del archivo.
        private FormNumeroLineas fNumLines = new FormNumeroLineas(); // Formulario para cargar el número de filas.
        private Stopwatch sw = new Stopwatch(); // Reloj timmer.
        private List<sFila> listFilas = new List<sFila>(); // Lista del tipo de estructura definido mas arriba.
        private List<sFila> listDesordenada = new List<sFila>(); // Lista original desordenada.
        Form fPrincipal; // Formulario principal.

        public FormParte3(TP_labo_programacion_II.FormPrincipal fP) {
            InitializeComponent();
            tabControl1.TabPages[0].BackColor = Color.FromArgb(40, 38, 39);
            tabControl1.TabPages[0].ForeColor = Color.White;
            fPrincipal =fP;
            openFileDialog1.Filter="CSV files (*.csv)|*.csv;"; // Filtro para abrir solo archivos csv.
            numeroDeFilas=1; // Inicialmente seteamos el número de filas en 1.

            // Inhabilitamos los botones al inicio de la aplición para no causar errores de overflow de memoria.
            alternarBotonesSort(false);
            cambiarNumeroFilasBoton.Enabled=false;
            ListaDesordenadaBoton.Enabled=false;
        }

        private void alternarBotonesSort(bool opc) { // Activa o desactiva los botones de sort.
            burbujaBoton.Enabled=opc;
            burbujaContBoton.Enabled=opc;
            InsertSortBoton.Enabled=opc;
            MergeSortBoton.Enabled=opc;
            quickSortBoton.Enabled=opc;
        }

        private void cargarListView() { // Función para cargar los datos del archivo. 
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listFilas.Clear();

            using(StreamReader reader = new StreamReader(fileName)) {
                string linea = reader.ReadLine(); // Leemos la primera linea y creamos las cabeceras de columnas del listview.
                string[] valores = linea.Split(';');
                listView1.Columns.Add(valores[0]);
                listView1.Columns.Add(valores[1]);
                listView1.Columns.Add(valores[2]);
                listView1.Columns.Add(valores[3]);

                for(int i = 0; i<numeroDeFilas; i++) {// Leemos las n filas, las almacenamos en el listView
                    linea = reader.ReadLine();        // y en una lista de filas con la estructura creada.
                    valores = linea.Split(';');
                    listFilas.Add(new sFila(valores[0], valores[1], valores[2], valores[3]));
                    listView1.Items.Add(new ListViewItem(valores));
                }
            }
            listDesordenada=new List<sFila>(listFilas); // Copiamos el contenido de la listFilas a la lista desordenada
                                                        // que es la que va a mantener los valores originales.
        }

        private void openFileButton_Click(object sender, EventArgs e) { // Función del boton para abrir archivos.
            if(fNumLines.ShowDialog()==DialogResult.OK) {
                numeroDeFilas=fNumLines.getNumeroDeFilas();

                if(openFileDialog1.ShowDialog()==DialogResult.OK) {
                    try {
                        fileName = openFileDialog1.FileName;
                        cargarListView();
                        alternarBotonesSort(true);
                        cambiarNumeroFilasBoton.Enabled=true;
                        ListaDesordenadaBoton.Enabled=true;
                    }
                    catch(IOException error) {
                        alternarBotonesSort(false);
                        cambiarNumeroFilasBoton.Enabled=false;
                        ListaDesordenadaBoton.Enabled=false;
                        MessageBox.Show(error.Message, "Error");
                    }
                }
            }
        }

        private void cambiarNumeroFilasBoton_Click(object sender, EventArgs e) { // Función del boton para cambiar el número de filas.
            if(fNumLines.ShowDialog()==DialogResult.OK && numeroDeFilas!=fNumLines.getNumeroDeFilas()) {
                numeroDeFilas=fNumLines.getNumeroDeFilas();
                cargarListView();
                alternarBotonesSort(true);
            }
        }

        private void actualizarListView(List<sFila> lFilas) { // Función para actualizar el listView.
            listView1.Items.Clear(); // Limpiamos el listView.
            for(int i=0; i<lFilas.Count; i++) { // Recargamos el listView.
                string[] fila = { lFilas[i].A, lFilas[i].B, lFilas[i].C, lFilas[i].D };
                listView1.Items.Add(new ListViewItem(fila));
            }
        }

        private void burbujaBoton_Click(object sender, EventArgs e) { // Función que llama al algoritmo burbuja sin contador.
            alternarBotonesSort(false);
            sw.Restart(); // Reiniciamos el contador de tiempo.
            Ordenador.burbujaSinContador(listFilas); // Ordenamos por ID la lista de filas, que contiene los datos del archivo.
            sw.Stop(); // Detenemos el contador de tiempo.
            actualizarListView(listFilas); // Actualizamos el listView con los datos ordenados por ID.
            // Mostramos un mensaje que dice el tiempo de ejecución del algoritmo y el nombre del método usado.
            MessageBox.Show("Tiempo de ejecución: " + sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff"), "Método Burbuja");
        }

        private void burbujaContBoton_Click(object sender, EventArgs e) { // Función que llama al algoritmo burbuja con contador.
            alternarBotonesSort(false);
            sw.Restart(); // Reiniciamos el contador de tiempo.
            int cont=Ordenador.burbujaConContador(listFilas); // Ordenamos por ID la lista de filas, que contiene los datos del archivo.
            sw.Stop(); // Detenemos el contador de tiempo.
            actualizarListView(listFilas); // Actualizamos el listView con los datos ordenados por ID.
            // Mostramos un mensaje que dice el tiempo de ejecución del algoritmo y el nombre del método usado.
            MessageBox.Show(
                "Tiempo de ejecución: "+sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff")+"\nCambios realizados: "+cont.ToString()+".",
                "Método Burbuja con contador de cambios"
            );
        }

        private void quickSortBoton_Click(object sender, EventArgs e) { // Función que llama al algoritmo quickSort.
            alternarBotonesSort(false);
            sw.Restart();
            Ordenador.QuickSort(listFilas);
            sw.Stop();
            actualizarListView(listFilas);
            MessageBox.Show("Tiempo de ejecución: " + sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff"), "Método QuickSort");
        }

        private void MergeSortBoton_Click(object sender, EventArgs e) {// Función que llama al algoritmo MergeSort.
            alternarBotonesSort(false);
            sw.Restart();
            Ordenador.MergeSort(listFilas);
            sw.Stop();
            actualizarListView(listFilas);
            MessageBox.Show("Tiempo de ejecución: " + sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff"), "Método MergeSort");
        }

        private void InsertSortBoton_Click(object sender, EventArgs e) {// Función que llama al algoritmo insertSort.
            alternarBotonesSort(false);
            sw.Restart();
            Ordenador.ordenarInsert(listFilas);
            sw.Stop();
            actualizarListView(listFilas);
            MessageBox.Show("Tiempo de ejecución: " + sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff"), "Método InsertSort");
        }

        private void ListaDesordenadaBoton_Click(object sender, EventArgs e) {
            actualizarListView(listDesordenada);
            listFilas=new List<sFila>(listDesordenada); // "Desordenamos la lista" copiamos la lista original a la que estaba ordenada.
            alternarBotonesSort(true);
        }

        private void FormParte3_FormClosed(object sender, FormClosedEventArgs e) { // Al cerrar este formulario volvemos a mostrar el principal.
            fPrincipal.Show();
        }
    }
}
