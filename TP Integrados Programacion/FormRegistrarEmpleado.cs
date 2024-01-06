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
    public partial class FormRegistrarEmpleado : Form
    {
        N_Persona p = new N_Persona();
        ApplicationDbContextContainer db = new ApplicationDbContextContainer();
        public FormRegistrarEmpleado()
        {
            InitializeComponent();
            CB_SucursalAsig.DataSource =ListGlossary.nombreAdministradores;
            CB_SucursalAsig.DisplayMember = "Nombre";
            CB_AdministradorRes.DataSource =ListGlossary.nombreSucursal;
            CB_AdministradorRes.DisplayMember = "Nombre";
        }

        private void CB_SucursalAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void TB_CrearEmp_Click(object sender, EventArgs e)
        {
            E_Empleado a = new E_Empleado();
            ListGlossary.nombreEmpleado.Add(a);
            a.Nombre = TB_NombreEmp.Text;
            a.Apellido = TB_ApellidoEmp.Text;
            a.Edad = Convert.ToInt32(TB_EdadEmp.Text);
            a.Cuil = TB_CuilEmp.Text;
            a.HorarioTrabajo = TB_HorarioEmp.Text;
            a.AdministradorAsignado = CB_AdministradorRes.Text;
            a.SecursalAsignada = CB_SucursalAsig.Text;
            a.NroCaja = Convert.ToInt32(TB_NroCaja.Text);
            a.BoletosVendidos = 0;
            p.GuardarEmpleado(a);
            p.MostrarDatosPersonas();
        }

        private void BT_VolverAdmin_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
