using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Problema_del_Viajante
{
    public struct Ciudad
    {
        public string nombre;
        public int x, y;
        public Ciudad(string nombre, int x, int y) {
            this.nombre = nombre;
            this.x = x;
            this.y = y;
        }
    }
    public partial class FormViajante : Form
    {
        private List<Ciudad> ciudades = new List<Ciudad>(); // Lista de ciudades en crudo, sin ordenar.
        private List<Ciudad> ciudadesOrdenadas = new List<Ciudad>(); // Lista de ciudades ya ordenadas por distancias.
        private double distanciaTotal; // Es para almacenar la distacia que se obtiene al sumar las distacias de las ciudades ya ordenadas.
        Form fPrincipal; // Formulario principal.

        public FormViajante(TP_labo_programacion_II.FormPrincipal fP)
        {
            InitializeComponent();
            fPrincipal=fP;

            // inicializacion para hacer prubas.

            Ciudad c1 = new Ciudad("1", 20, 12), c2 = new Ciudad("2", 22, 11), c3 = new Ciudad("3", 0, 0), c4 = new Ciudad("4", 100, 100);
            ciudades.Add(c1);
            ciudades.Add(c2);
            ciudades.Add(c3);
            ciudades.Add(c4);
            string[] fila = {
                c1.nombre,
                Convert.ToString(c1.x),
                Convert.ToString(c1.y)
            };
            listCiudades.Items.Add(new ListViewItem(fila));
            string[] fila2 = {
                c2.nombre,
                Convert.ToString(c2.x),
                Convert.ToString(c2.y)
            };
            listCiudades.Items.Add(new ListViewItem(fila2));
            string[] fila3 = {
                c3.nombre,
                Convert.ToString(c3.x),
                Convert.ToString(c3.y)
            };
            listCiudades.Items.Add(new ListViewItem(fila3));
            string[] fila4 = {
                c4.nombre,
                Convert.ToString(c4.x),
                Convert.ToString(c4.y)
            };
            listCiudades.Items.Add(new ListViewItem(fila4));

            // fin de inicializacion para hacer pruebas.

            if (ciudades.Count < 3) // Inhabilita el boton resolver para no causar errores cuando la lista de ciudades tiene menos de 3 elementos.
            {
                botonResolver.Enabled = false; 
            }
        }

        private double calcularDistancia(Ciudad c1, Ciudad c2) // Calcula la distancia entre dos ciudades.
        {
            return Math.Sqrt(Math.Pow((c2.x - c1.x), 2) + Math.Pow((c2.y - c1.y), 2));
        }

        private void ordenarCiudades() // Ordena las ciudades en una lista iniciando por la primera ingresada y buscando la ciudad vecina mas cercana (Calcula la ruta).
        {
            ciudadesOrdenadas.Add(ciudades[0]);
            List<Ciudad> aux = new List<Ciudad>(ciudades); // Hace una copia de la lista original para no realizar modificaciones sobre la misma, en caso de ser necesaria otra vez.
            aux.RemoveAt(0); // Elimino el primer elemento para no calcular la primer distancia entre la primer ciudad.
            int posMin;
            int i;
            double distMin;
            double distAux;
            distanciaTotal = 0;

            while (ciudadesOrdenadas.Count != ciudades.Count) // Mientras la lista ciudades ordenadas no alcance el tamaño de la lista original se continua en el bucle.
            {
                i = 0;
                distMin = calcularDistancia(ciudadesOrdenadas.Last(), aux[0]); // Calculo la distancia entre la ciudad en la que estoy ahora y la primer ciudad disponibles.
                posMin = 0;
                while (i < aux.Count)
                {
                    distAux = calcularDistancia(ciudadesOrdenadas.Last(), aux[i]); // Calculo la distancia entre la ciudad en la que estoy ahora y las que quedan disponibles.
                    if (distMin > distAux) // si la nueva distancia es menor la guardo como distancia minima y guardo la pocision de la ciudad i-esima.
                    {
                        distMin = distAux;
                        posMin = i;
                    }
                    i++;
                }
                distanciaTotal += distMin; // Sumo las distancias parciales para obtener la distancia total.
                ciudadesOrdenadas.Add(aux[posMin]); // agrego la ciudad mas cercana.
                aux.RemoveAt(posMin); // elimino la ciudad mas cercana del arreglo auxiliar asi no vuelvo a la misma, ni a las anteriormente cargadas.
            }
            distanciaTotal += calcularDistancia(ciudadesOrdenadas.Last(), ciudadesOrdenadas[0]); // Calculo y sumo la distancia entre la última ciudad agregada y la ciudad de origen
            ciudadesOrdenadas.Add(ciudadesOrdenadas[0]); // Agrego nuevamente la ciudad de origen al arreglo, ya que hay que volver al inicio.
        }

        private void botonAgregar_Click(object sender, EventArgs e) // Click boton Agregar. Agrega un elemento a la lista de ciudades y al ListView.
        {
            string nombre;
            int last = ciudades.Count+1;
            if(nombreCiudad.Text=="") {
                nombre=Convert.ToString(last);
            }
            else nombre=nombreCiudad.Text;
            string[] fila = {
                nombre,
                Convert.ToString(posicionX.Value),
                Convert.ToString(posicionY.Value)
            };
            
            listCiudades.Items.Add(new ListViewItem(fila));

            Ciudad fila2 = new Ciudad(nombre, Convert.ToInt32(posicionX.Value), Convert.ToInt32(posicionY.Value));

            ciudades.Add(fila2);

            if (ciudades.Count >= 3) // habilita el boton resolver si hay 3 o mas ciudades en la lista
            {
                botonResolver.Enabled = true;
            }
        }

        private void botonResolver_Click(object sender, EventArgs e) // Click boton Resolver. Ordena las ciudades mediante el vecino mas cercano y actualiza el ListView mostrando la ruta calcualda.
        {
            ciudadesOrdenadas.Clear(); // Limpia la lista para asegurar que no haya datos basura.
            ordenarCiudades(); // Llama a ordenarCiudades para calcular la ruta.
            listCiudades.Items.Clear(); // Limpia el ListView para luego mostrar la ruta calculada.

            foreach (Ciudad c in ciudadesOrdenadas)
            {
                string[] fila = {
                    c.nombre,
                    Convert.ToString(c.x),
                    Convert.ToString(c.y)
                };
                listCiudades.Items.Add(new ListViewItem(fila));
            }

            labelDistTotal.Text = "Distancia total: " + Convert.ToString(distanciaTotal);
            Grafico graf = new Grafico(ciudadesOrdenadas);
            graf.Show();
        }

        private void botonLimpiar_Click(object sender, EventArgs e) // Click boton Limpiar. Borra el contenido de todas las listas, incluida la del listview.
        {
            ciudades.Clear();
            ciudadesOrdenadas.Clear();
            listCiudades.Items.Clear();
            botonResolver.Enabled = false; // inhabilita el boton resolver para no causar errores cuando la lista de ciudades esta vacia
            distanciaTotal = 0;
            labelDistTotal.Text = "Distancia total: " + Convert.ToString(distanciaTotal);
        }

        private void FormViajante_FormClosed(object sender, FormClosedEventArgs e) { // Al cerrar este formulario volvemos a mostrar el principal.
            fPrincipal.Show();
        }
    }
}
