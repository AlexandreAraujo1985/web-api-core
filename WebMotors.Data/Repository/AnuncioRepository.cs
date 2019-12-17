using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebMotors.Data.Entity;
using WebMotors.Data.Repository.Interfaces;

namespace WebMotors.Data.Repository
{
    public class AnuncioRepository : IAnuncioRepository
    {
        private WebMotorsContext _context;
        public AnuncioRepository(WebMotorsContext context)
        {
            _context = context;
        }

        public async Task AtualizarAnuncio(int anuncioId, AnuncioEntity anuncio)
        {
            _context.Entry(anuncio).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeletarAnuncio(int anuncioId)
        {
            var anuncio = await ObterAnuncio(anuncioId);

            _context.Set<AnuncioEntity>().Remove(anuncio);
            await _context.SaveChangesAsync();
        }

        public async Task IncluirAnuncio(AnuncioEntity anuncio)
        {
            _context.Set<AnuncioEntity>().Add(anuncio);
            await _context.SaveChangesAsync();
        }

        public async Task<AnuncioEntity> ObterAnuncio(int anuncioId) =>
           await _context.Set<AnuncioEntity>().FindAsync(anuncioId);
    }
}
