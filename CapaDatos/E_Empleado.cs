using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class E_Empleado:E_Persona
    {
        public string SecursalAsignada { get; set; }
        public String AdministradorAsignado { get; set; }
        public int NroCaja { get; set; }
        public int BoletosVendidos { get; set; }
    }
}
