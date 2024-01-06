using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Sucursal
    {
        ApplicationDbContextContainer db = new ApplicationDbContextContainer();
        public void GuardarSucursal(Sucursal sucursal)
        {
            db.Sucursales.Add(sucursal);
            db.SaveChanges();
        }

        public List<Sucursal> MostrarDatosSucursales()
        {
            var query = from x in db.Sucursales select x;
            return query.ToList();
        }
    }
}
