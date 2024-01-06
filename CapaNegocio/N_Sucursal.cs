using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class N_Sucursal
    {
        ApplicationDbContextContainer db = new ApplicationDbContextContainer();
        D_Sucursal metodos = new D_Sucursal();
        public void GuardarSucursal(E_Sucursal sucursal)
        {
            Sucursal s = new Sucursal();
            s.Nombre = sucursal.Nombre;
            s.Direccion = sucursal.Direccion;
            s.Horarios = sucursal.Horarios;
            metodos.GuardarSucursal(s);
        }

        public List<Sucursal> GuardarSucursal()
        {
           return metodos.MostrarDatosSucursales();
        }
    }
}
