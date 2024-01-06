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
    public partial class FormIngresarSucursal : Form
    {
        N_Sucursal metodosNegocio = new N_Sucursal();
        public FormIngresarSucursal()
        {
            InitializeComponent();
        }

        private void BT_CrearSucursal_Click(object sender, EventArgs e)
        {
            E_Sucursal s = new E_Sucursal();
            ListGlossary.nombreSucursal.Add(s);
            s.Nombre = TB_NombreSucursal.Text;
            s.Direccion = TB_Direccion.Text;
            s.Horarios = TB_HorarioS.Text;
        }

        private void BT_VolverAdmin_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
