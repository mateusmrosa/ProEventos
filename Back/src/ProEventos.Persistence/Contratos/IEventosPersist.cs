using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includesPalestrantes = false);
        Task<Evento[]> GetAllEventosAsync(bool tema);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includesPalestrantes = false);
    }
}