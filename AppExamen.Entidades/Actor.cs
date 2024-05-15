using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExamen.Entidades
{
    // Entidad Actor
    public class Actor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }

        public List<Pelicula>? Peliculas { get; set; } //FK
    }
}
