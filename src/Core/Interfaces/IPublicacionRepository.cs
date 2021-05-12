using projectSoft.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace projectSoft.Interfaces
{
    public interface IPublicacionRepository
    {
        IEnumerable<Publicacion> GetPublicaciones();
        Publicacion GetPublicacion(int id);
        Task<IEnumerable<Publicacion>> SetPublicacionAsync(List<Publicacion> publicacion);
        Task<Publicacion> UpdatePublicacion(Publicacion publicacion);
        Task<Publicacion> RemovePublicacion(int id);
    }
}