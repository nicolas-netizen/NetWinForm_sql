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
    public partial class FormIngresarAdministrador : Form
    {
        N_Persona MetodosNegocio = new N_Persona();
        public FormIngresarAdministrador()
        {
            InitializeComponent();
        }

        private void BT_VolverAdmin_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void TB_CrearAdmin_Click(object sender, EventArgs e)
        {
            
            E_Administrativo a = new E_Administrativo();
            ListGlossary.nombreAdministradores.Add(a);
            a.Nombre = TB_NombreAdmin.Text;
            a.Apellido = TB_ApellidoAdmin.Text;
            a.Edad = Convert.ToInt32(TB_EdadAdmin.Text);
            a.Cuil = TB_CuilAdmin.Text;
            a.HorarioTrabajo = TB_HorarioAdmin.Text;
            a.Sector = TB_Sector.Text;
            MetodosNegocio.GuardarAdministrador(a);
            MetodosNegocio.MostrarDatosPersonas();
        }
    }
}
