using System;
using System.Collections.Generic;
namespace Dominio
{
    public partial class Publicacion
    {
        public Publicacion()
        {
            //Comentario = new HashSet<Comentario>();
        }

        public int IdPublicacion { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        //public virtual Usuario IdUsuarioNavigation { get; set; }
        //public virtual ICollection<Comentario> Comentario { get; set; }

        //El uso de objetos JSON anidados dificulta la actualizacion y la eliminacion de
        //los mismos debido a q se usan arreglos y no listas
        public virtual List<int> com { get; set; }
    }
}