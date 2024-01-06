using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Cliente
    {
        ApplicationDbContextContainer db = new ApplicationDbContextContainer();
        D_Cliente metodos = new D_Cliente();
        public void GuardarCliente(E_Cliente cliente)
        {
            Cliente c = new Cliente();
            c.Nombre = cliente.Nombre;
            metodos.GuardarCliente(c);
        }
        public List<Cliente> MostrarCliente()
        {
            return metodos.MostrarDatos();
        }
    }
}
