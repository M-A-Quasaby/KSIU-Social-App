using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class KSIUContext : DbContext
    {
        public KSIUContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AppUser> Users { get; set; }
    }
}
