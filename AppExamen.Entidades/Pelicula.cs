using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppExamen.Entidades
{
    public class Pelicula
    {
        [Key]
        public int Id { get; set; } //PK
        public string Titulo { get; set; }
        public int Año { get; set; }
        public string Director { get; set; }

        public List<Actor> Actores { get; set; }
    }
}
