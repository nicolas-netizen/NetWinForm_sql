using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Persona
    {
        ApplicationDbContextContainer db = new ApplicationDbContextContainer();
        D_Persona metodos = new D_Persona();
        public void GuardarAdministrador(E_Administrativo administrativo)
        {
            Administrativo a = new Administrativo();
            a.Nombre = administrativo.Nombre;
            a.Edad = administrativo.Edad;
            a.Apellido = administrativo.Apellido;
            a.HorarioTrabajo = administrativo.HorarioTrabajo;
            a.Cuil = administrativo.Cuil;
            a.Sector = administrativo.Sector;
            metodos.GuardarAdministrador(a);
        }

        public void GuardarEmpleado(E_Empleado empleado)
        {
            Empleado a = new Empleado();
            a.Nombre = empleado.Nombre;
            a.Edad = empleado.Edad;
            a.Apellido = empleado.Apellido;
            a.HorarioTrabajo = empleado.HorarioTrabajo;
            a.Cuil = empleado.Cuil;
            a.SecursalAsignada = empleado.SecursalAsignada;
            a.AdministradorAsignado = empleado.AdministradorAsignado;
            a.NroCaja = empleado.NroCaja;
            a.BoletosVendidos = empleado.BoletosVendidos;
            metodos.GuardarEmpleado(a);
        }

        public List<Persona> MostrarDatosPersonas()
        {
            return metodos.MostrarDatos();
        }
    }
}
