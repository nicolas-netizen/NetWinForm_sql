using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Cliente
    {
        ApplicationDbContextContainer db = new ApplicationDbContextContainer();
        public void GuardarCliente(Cliente cliente)
        {
            db.Clientes.Add(cliente);
            db.SaveChanges();
        }
        public List<Cliente> MostrarDatos()
        {
            var query = from x in db.Clientes select x;
            return query.ToList();
        }
    }
}
