using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
   public class N_Pelicula
    {
        ApplicationDbContextContainer db = new ApplicationDbContextContainer();
        D_Pelicula metodos = new D_Pelicula();
        public void GuardarPelicula(E_Pelicula pelicula )
        {
            Pelicula p = new Pelicula();
            p.Nombre = pelicula.Nombre;
            p.Idioma = pelicula.Idioma;
            p.Genero = pelicula.Genero;
            p.Duracion = pelicula.Duracion;
            p.Subtitulos = Convert.ToBoolean(pelicula.Subtitulos);
            metodos.GuardarPelicula(p);
        }

        public List<Pelicula> MostrarDatos()
        {
            return metodos.MostrarDatos();
        }
    }
}
