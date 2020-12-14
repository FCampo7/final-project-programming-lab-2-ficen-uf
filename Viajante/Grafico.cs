using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Problema_del_Viajante
{
    public partial class Grafico : Form
    {
        private List<Ciudad> citys;
        public Grafico(List<Ciudad> ciudades) {
            InitializeComponent();
            citys=new List<Ciudad>(ciudades);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            graficar(e.Graphics);
        }

        private void graficar(Graphics grafic) {
            float escala = funcionEscala();//(trackBar1.Value*25)/10;
            float tam = 10f;
            Pen lapiz = new Pen(Brushes.Red, tam/6);
            Pen lapiz2 = new Pen(Brushes.White, tam/6);
            Font font = new Font(FontFamily.GenericMonospace, 15);
            float x, y;
            float xm, ym;
            PointF pf;
            for(int i = 0; i<citys.Count-1; i++) {
                x = citys[i].x*escala;
                y = citys[i].y*escala;
                grafic.DrawEllipse(lapiz2, x-tam/2f, y-tam/2f, tam, tam);
                grafic.DrawLine(lapiz, x, y, citys[i+1].x*escala, citys[i+1].y*escala);
                pf = new PointF(x, y);
                grafic.DrawString(citys[i].nombre, font, Brushes.White, pf);
                xm=(x+citys[i+1].x*escala)/2;
                ym=(y+citys[i+1].y*escala)/2;
                pf=new PointF(xm, ym);
                grafic.DrawString(Convert.ToString(i), font, Brushes.Aquamarine, pf);
            }
        }

        private float funcionEscala() {
            float scala=(trackBar1.Value-1f)/1000f;
            if(pictureBox1.Width>pictureBox1.Height) scala*=pictureBox1.Height;
            else scala*=pictureBox1.Width;
            return scala;
        }

        private void botonCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e) {
            pictureBox1.Refresh();
        }

        private void Grafico_Resize(object sender, EventArgs e) {
            pictureBox1.Refresh();
        }
    }
}
