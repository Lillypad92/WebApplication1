using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class AnimalContext : DbContext
    {
        public AnimalContext (DbContextOptions<AnimalContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Animal> Animal { get; set; } = default!;
    }
}
