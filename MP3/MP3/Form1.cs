using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3
{

    public partial class Form1 : Form
    {
        List<Cancion> canciones = new List<Cancion>();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void b_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.InitialDirectory = "F:\\Musica";
               

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string []C = openFileDialog.SafeFileNames;
                    string [] R = openFileDialog.FileNames;
                    for (int i = 0; i < C.Length; i++)
                    {
                        String[] filtro = C[i].Split('.');
                        if (filtro[filtro.Length - 1].Equals("mp3") || filtro[filtro.Length - 1].Equals("wmv"))
                        {
                            string nombre=C[i], ruta=R[i], albunes="DESCONOCIDO", genero = "DESCONOCIDO", 
                                duracion = "DESCONOCIDO", anio = "DESCONOCIDO";

                            try
                            {
                                //CON LA LIBRERIA TAGLIB ENTRO A LAS PROPIEDADES DE
                                //LAS CANCIONES SI NO EXITEN LAS PROPIEDADES QUE BUSCO APARECERAS CON UN DESCONOCIDO
                                //QUE FUE EL VALOR QUE LES DI POR DEFECTO.
                                TagLib.File datos = TagLib.File.Create(R[i]);
                                genero = datos.Tag.Genres[0];
                                duracion = Convert.ToString(datos.Properties.Duration);
                                anio = Convert.ToString(datos.Tag.Year);
                                albunes = datos.Tag.Album;
                            }
                            catch
                            {

                            }

                            Cancion temporal = new Cancion(C[i], R[i], albunes, genero,duracion ,anio);
                            canciones.Add(temporal);
                            Lista_Canciones.Items.Add(C[i]);

                        }
                        else
                        {
                            MessageBox.Show("SOLO SE PUEDEN SELECCIONAR CANCIONES");
                        }
                    }
                    

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Lista_Canciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lista_Canciones.SelectedIndex == 0)
            {
                Atras.Enabled = false;
                Primero.Enabled = false;
            }
            else
            {
                Atras.Enabled = true;
                Primero.Enabled = true;
            }
            if (Lista_Canciones.SelectedIndex == canciones.Count-1)
            {
                Siguiente.Enabled = false;
                Ultimo.Enabled = false;
            }
            else
            {
                Siguiente.Enabled = true;
                Ultimo.Enabled = true;
            }
            var consulta = canciones.Where(a => a.nombre.Equals(Lista_Canciones.SelectedItem));
            foreach (var temporal in consulta)
            {
                Lista_datos.Items.Clear();
                Lista_datos.Items.Add("NOMBRE :" + temporal.nombre);
                Lista_datos.Items.Add("ALBUM :" + temporal.album);
                Lista_datos.Items.Add("GENERO :" + temporal.genero);
                Lista_datos.Items.Add("DURACION :" + temporal.duracion);
                Lista_datos.Items.Add("ANIO :" + temporal.year);
                PLAYER.URL = temporal.ruta;
            }                  
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            PLAYER.Ctlcontrols.play();
        }

        private void Detener_Click(object sender, EventArgs e)
        {
            PLAYER.Ctlcontrols.pause();
        }

        private void Pausar_Click(object sender, EventArgs e)
        {
            PLAYER.Ctlcontrols.stop();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            
            Lista_Canciones.SetSelected(Lista_Canciones.SelectedIndex - 1,true);
        }

        private void Primero_Click(object sender, EventArgs e)
        {
            Lista_Canciones.SetSelected(0, true);

        }

        private void Ultimo_Click(object sender, EventArgs e)
        {
            Lista_Canciones.SetSelected(canciones.Count-1, true);

        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            Lista_Canciones.SetSelected(Lista_Canciones.SelectedIndex +1, true);

        }
    }
}
