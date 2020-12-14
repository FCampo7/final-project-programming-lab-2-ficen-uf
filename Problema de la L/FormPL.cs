using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_de_la_L
{
    public partial class FormPL : Form
    {
        Form fPrincipal; // Formulario principal.
        int varSize; // Tamaño que va a tener cada label.
        int tam; // Tamaño de la matriz tam X tam.
        int[,] matriz; // Matriz cuadrada de Labels.

        public FormPL(TP_labo_programacion_II.FormPrincipal fP) {
            InitializeComponent();
            varSize=20;
            tam = Convert.ToInt32(Math.Pow(2, Convert.ToDouble(valorK.Value)));
            matriz=new int[tam, tam];
            RefrescarPanel();
            fPrincipal=fP;
        }

        private void pintarCuadros(Brush brushe, Graphics g, int i, int j) {
            Pen pincel = new Pen(Color.Black, 0.5f);
            g.FillRectangle(brushe, i*varSize, j*varSize, varSize, varSize);
            g.DrawRectangle(pincel, i*varSize, j*varSize, varSize, varSize);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            if(matriz!=null) {
                if(pictureBox1.Height>=pictureBox1.Width) varSize=pictureBox1.Width/tam; // Ajustamos el tamaño de los labes al alto o ancho de la ventana.
                else varSize=pictureBox1.Height/tam;
                for(int i = 0; i<tam; i++) {
                    for(int j = 0; j<tam; j++) {
                        switch(matriz[i, j]) {
                            case 0:
                            pintarCuadros(Brushes.White, e.Graphics, i, j);
                            break;
                            case 1:
                            pintarCuadros(Brushes.BlueViolet, e.Graphics, i, j);
                            break;
                            case 2:
                            pintarCuadros(Brushes.CornflowerBlue, e.Graphics, i, j);
                            break;
                            case 3:
                            pintarCuadros(Brushes.Coral, e.Graphics, i, j);
                            break;
                            case 4:
                            pintarCuadros(Brushes.MediumSeaGreen, e.Graphics, i, j);
                            break;
                            case 5:
                            pintarCuadros(Brushes.Black, e.Graphics, i, j);
                            break;
                            default:
                            pintarCuadros(Brushes.White, e.Graphics, i, j);
                            break;
                        }
                    }
                }
            }
        }

        private void RefrescarPanel() { // Refresca el panel para seleccionar otro cuadrado.
            for(int i = 0; i<tam; i++) {
                for(int j = 0; j<tam; j++) {
                    matriz[i, j]=0;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            try {
                if(varSize!=0) {
                    MouseEventArgs mouseEventArgs = e as MouseEventArgs;
                    int posX;
                    int posY;
                    posX=mouseEventArgs.X/varSize;
                    posY=mouseEventArgs.Y/varSize;
                    if(posX<tam && posY<tam && posX>=0 && posY>=0) { //Condicion para no salir fuera de la matriz.
                        RefrescarPanel();
                        matriz[posX, posY]=5;
                        divideyvenceras();
                        pictureBox1.Refresh();
                    }
                }
            }
            catch(NullReferenceException error) {
                Console.WriteLine(error.Message);
            }
        }

        private void botonMostrarMatriz_Click(object sender, EventArgs e) {
            tam = Convert.ToInt32(Math.Pow(2, Convert.ToDouble(valorK.Value))); // Calculamos el tamaño para construir la matriz.
            matriz=new int[tam, tam]; // Damos tamaño a la matriz.
            RefrescarPanel();
            pictureBox1.Refresh();
        }

        // Funciónes para pintar las distintas L's.
        private void pintarL4(int x, int y) {
            matriz[x+1, y] = 4;
            matriz[x+1, y+1] = 4;
            matriz[x, y+1] = 4;
        }
        private void pintarL1(int x, int y) {
            matriz[x-1, y] = 1;
            matriz[x-1, y+1] = 1;
            matriz[x, y+1] = 1;
        }
        private void pintarL2(int x, int y) {
            matriz[x, y-1] = 2;
            matriz[x+1, y-1] = 2;
            matriz[x+1, y] = 2;
        }
        private void pintarL3(int x, int y) {
            matriz[x-1, y-1] = 3;
            matriz[x-1, y] = 3;
            matriz[x, y-1] = 3;
        }

        // Inicio del algoritmo divide and conquer de Llenado de L's.
        private void divideyvenceras() { // Función vórtice.
            divideyvenceras(0, tam, 0, tam);
        }

        private void divideyvenceras(int inicioI, int finI, int inicioJ, int finJ) {
            int posX=0, posY=0; // Almacenan la posicion donde hay un cuadrado pintado, inicializado en 0.
            int pmI = (inicioI+finI)/2, pmJ = (inicioJ+finJ)/2; // Obtenemos la posicion de la mitad de la matriz.
            bool banderaBreak = false; // Bandera para luego hacer el break del primer for.

            for(int i = inicioI; i<finI; i++) {
                for(int j = inicioJ; j<finJ; j++) {
                    if(matriz[i, j]!=0) { // Revisamos si en esa posicion hay un cuadrado pintado
                        posX=i;                                               // y la guardamos.
                        posY=j;
                        banderaBreak=true;
                        break;
                    }
                }
                if(banderaBreak) {
                    break;
                }
            }

            if(posX<pmI) { // Dependiendo de la posicion vemos con que L pintar.
                if(posY<pmJ) pintarL4(pmI-1, pmJ-1);
                if(posY>=pmJ) pintarL2(pmI-1, pmJ);
            }
            if(posX>=pmI) {
                if(posY<pmJ) pintarL1(pmI, pmJ-1);
                if(posY>=pmJ) pintarL3(pmI, pmJ);
            }

            if(finI-inicioI<=2) return; // Condición de salida.

            // Dividimos la matriz en matrices cuadradas mas pequeñas.

            divideyvenceras(inicioI, (inicioI+finI)/2, inicioJ, (inicioJ+finJ)/2);
            divideyvenceras((inicioI+finI)/2, finI, inicioJ, (inicioJ+finJ)/2);
            divideyvenceras(inicioI, (inicioI+finI)/2, (inicioJ+finJ)/2, finJ);
            divideyvenceras((inicioI+finI)/2, finI, (inicioJ+finJ)/2, finJ);
        }

        // Fin algoritmo.

        private void FormPL_Resize(object sender, EventArgs e) {
            pictureBox1.Refresh();
        }

        private void FormPL_FormClosed(object sender, FormClosedEventArgs e) { // Al cerrar este formulario volvemos a mostrar el principal.
            fPrincipal.Show();
        }

        private void botonMostrarMatriz_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode==Keys.Enter) {
                tam = Convert.ToInt32(Math.Pow(2, Convert.ToDouble(valorK.Value))); // Calculamos el tamaño para construir la matriz.
                matriz=new int[tam, tam]; // Damos tamaño a la matriz.
                RefrescarPanel();
                pictureBox1.Refresh();
            }
        }

        private void valorK_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode==Keys.Enter) {
                tam = Convert.ToInt32(Math.Pow(2, Convert.ToDouble(valorK.Value))); // Calculamos el tamaño para construir la matriz.
                matriz=new int[tam, tam]; // Damos tamaño a la matriz.
                RefrescarPanel();
                pictureBox1.Refresh();
            }
        }
    }
}
