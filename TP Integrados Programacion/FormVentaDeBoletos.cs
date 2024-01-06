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
    public partial class FormVentaDeBoletos : Form
    {
        N_Cliente metodosnegocio = new N_Cliente();
        public FormVentaDeBoletos()
        {
            InitializeComponent();
            CB_EmpleadoAsig.DataSource = ListGlossary.nombreEmpleado;
            CB_EmpleadoAsig.DisplayMember = "Nombre";
            CB_PeliculasElegir.DataSource = ListGlossary.nombrePelicula;
            CB_PeliculasElegir.DisplayMember = "Nombre";
            CB_SucursalVenta.DataSource = ListGlossary.nombreSucursal;
            CB_SucursalVenta.DisplayMember = "Nombre";
        }

        private void BT_Venta_Click(object sender, EventArgs e)
        {
            E_Cliente c = new E_Cliente();
            c.Nombre = TB_NombreCli.Text;
            metodosnegocio.GuardarCliente(c);
            metodosnegocio.MostrarCliente();
            ListGlossary.nombreCliente(c);
        }

        private void BT_Volver_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
