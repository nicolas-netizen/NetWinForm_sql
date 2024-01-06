using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Pelicula
    {
        ApplicationDbContextContainer db = new ApplicationDbContextContainer();
        public void GuardarPelicula(Pelicula pelicula)
        {
            db.Peliculas.Add(pelicula);
            db.SaveChanges();
        }
        public List<Pelicula> MostrarDatos()
        {
            var query = from x in db.Peliculas select x;
            return query.ToList();
        }
    }
}
