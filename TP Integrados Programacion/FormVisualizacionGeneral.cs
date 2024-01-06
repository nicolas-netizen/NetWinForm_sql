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
    public partial class FormVisualizacionGeneral : Form
    {
        ApplicationDbContextContainer db = new ApplicationDbContextContainer();
        public FormVisualizacionGeneral()
        {
            InitializeComponent();
            DG_Administrativo.DataSource = null;
            DG_Administrativo.DataSource = ListGlossary.nombreAdministradores;
            DG_Empleados.DataSource = null;
            DG_Empleados.DataSource = ListGlossary.nombreEmpleado;
            DG_Peliculas.DataSource = null;
            DG_Peliculas.DataSource = ListGlossary.nombrePelicula;
            DG_Sucursales.DataSource = null;
            DG_Sucursales.DataSource = ListGlossary.nombreSucursal
        }

        private void BT_Volver_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

    }
}
