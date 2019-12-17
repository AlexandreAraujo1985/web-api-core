using System.Threading.Tasks;
using WebMotors.Data.Entity;

namespace WebMotors.Data.Repository.Interfaces
{
    public interface IAnuncioRepository
    {
        Task<AnuncioEntity> ObterAnuncio(int anuncioId);
        Task IncluirAnuncio(AnuncioEntity anuncio);
        Task AtualizarAnuncio(int anuncioId, AnuncioEntity anuncio);
        Task DeletarAnuncio(int anuncioId);
    }
}
