using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Persona
    {
        ApplicationDbContextContainer db = new ApplicationDbContextContainer();
        public void GuardarAdministrador(Administrativo administrativo)
        {
            db.Personas.Add(administrativo);
            db.SaveChanges();
        }

        public void GuardarEmpleado(Empleado empleado)
        {
            db.Personas.Add(empleado);
            db.SaveChanges();
        }

        public List<Persona> MostrarDatos()
        {
            var query = from x in db.Personas select x;
            return query.ToList();
        }
    }
}
