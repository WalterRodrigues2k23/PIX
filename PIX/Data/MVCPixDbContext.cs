using Microsoft.EntityFrameworkCore;
using PIX.Models.Domain;

namespace PIX.Data
{
    public class MVCPixDbContext : DbContext
    {
        public MVCPixDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
    }
}
