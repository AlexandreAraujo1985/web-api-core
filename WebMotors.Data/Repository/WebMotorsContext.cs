using Microsoft.EntityFrameworkCore;
using WebMotors.Data.Entity;

namespace WebMotors.Data.Repository
{
    public class WebMotorsContext : DbContext
    {
        public WebMotorsContext(DbContextOptions<WebMotorsContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<AnuncioEntity> Anuncios { get; set; }
    }
}
