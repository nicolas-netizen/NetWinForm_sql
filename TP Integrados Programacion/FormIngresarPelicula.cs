using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace TP_Integrados_Programacion
{
    public partial class FormIngresarPelicula : Form
    {
        N_Pelicula metodosNegocios = new N_Pelicula();
        public FormIngresarPelicula()
        {
            InitializeComponent();
        }

        private void BT_VolverPeli_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void BT_CrearPeli_Click(object sender, EventArgs e)
        {
            bool s = false;
            if(CB_Subtitulos.Text == "YES")
            {
                s = true;
            }
            E_Pelicula p = new E_Pelicula();
            ListGlossary.nombrePelicula.Add(p);
            p.Nombre = TB_NombrePelicula.Text;
            p.Idioma = TB_Idioma.Text;
            p.Genero = TB_Genero.Text;
            p.Subtitulos = Convert.ToString(s);
            metodosNegocios.GuardarPelicula(p);
            metodosNegocios.MostrarDatos();
        }
    }
}
