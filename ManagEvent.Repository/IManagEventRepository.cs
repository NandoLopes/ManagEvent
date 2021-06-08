using System.Threading.Tasks;
using ManagEvent.Domain;

namespace ManagEvent.Repository
{
    public interface IManagEventRepository
    {
        //GERAL
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //EVENTOS
        Task<Evento[]> GetAllEventosAsyncByTema(string tema, bool includePalestrantes);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);
        Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrantes);

        //Palestrantes
        Task<Palestrante[]> GetAllPalestrantesAsyncByName(string name, bool includePalestrantes);
        Task<Palestrante> GetPalestrantesAsync(int PalestranteId, bool includePalestrantes);
    }
}