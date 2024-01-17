using DAppAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<AppUser> Users { get; set; }
    }
}
