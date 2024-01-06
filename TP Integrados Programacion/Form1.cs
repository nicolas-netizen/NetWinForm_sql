using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Integrados_Programacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_VentaDeBoletos_Click(object sender, EventArgs e)
        {
            FormVentaDeBoletos fv = new FormVentaDeBoletos();
            this.Hide();
            fv.Show();
        }

        private void BT_RegistroAdmin_Click(object sender, EventArgs e)
        {
            FormIngresarAdministrador fa = new FormIngresarAdministrador();
            this.Hide();
            fa.Show();
        }

        private void TB_RegistrarEmp_Click(object sender, EventArgs e)
        {
            FormRegistrarEmpleado fe = new FormRegistrarEmpleado();
            this.Hide();
            fe.Show();
        }

        private void BT_IngresarSucursal_Click(object sender, EventArgs e)
        {
            FormIngresarSucursal fs = new FormIngresarSucursal();
            this.Hide();
            fs.Show();
        }

        private void BT_IngresarPelicula_Click(object sender, EventArgs e)
        {
            FormIngresarPelicula fp = new FormIngresarPelicula();
            this.Hide();
            fp.Show();
        }

        private void BT_Visualizar_Click(object sender, EventArgs e)
        {
            FormVisualizacionGeneral fg = new FormVisualizacionGeneral();
            this.Hide();
            fg.Show();
        }
    }
}
