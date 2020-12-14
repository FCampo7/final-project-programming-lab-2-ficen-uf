using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP_labo_programacion_II
{
    class TitleBar : Panel
    {
        Form fPrincipal;
        bool drag = false;
        Point pInicio = new Point(0, 0);
        Button bClose = new Button();
        Label lTitle = new Label();

        public TitleBar(Form f, string titulo)
        {
            fPrincipal = f;
            
            this.Dock = DockStyle.Top;

            this.Height = 40;

            lTitle.Text = titulo;
            lTitle.ForeColor = Color.White;
            lTitle.Font = new Font(lTitle.Font, FontStyle.Bold);
            lTitle.TextAlign = ContentAlignment.MiddleLeft;
            lTitle.Location = new Point(0, 0);
            lTitle.Size = new Size(fPrincipal.Size.Width-50, 40);
            
            bClose.Text = "X";
            bClose.FlatStyle = FlatStyle.Flat;
            bClose.BackColor = Color.Red;
            bClose.FlatAppearance.BorderColor = Color.Red;
            bClose.FlatAppearance.MouseDownBackColor = Color.Red;
            bClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 48, 47);
            bClose.ForeColor = Color.White;
            bClose.Height = 25;
            bClose.Width = 34;
            bClose.Location = new Point(fPrincipal.Size.Width-40, 5);

            bClose.Click += new EventHandler(bClose_Click);

            lTitle.MouseDown += new MouseEventHandler(mouseDown);
            lTitle.MouseUp += new MouseEventHandler(mouseUp);
            lTitle.MouseMove += new MouseEventHandler(mouseMove);

            this.Controls.Add(lTitle);
            this.Controls.Add(bClose);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            fPrincipal.Close();
        }

        private void mouseDown(object sender, MouseEventArgs e) {
            pInicio = e.Location;
            this.drag = true;
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void mouseMove(object sende, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - pInicio.X, p2.Y - pInicio.Y);

                fPrincipal.Location = p3;
            }
        }

    }
}
