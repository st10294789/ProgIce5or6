using Microsoft.EntityFrameworkCore;
using ProgIce5or6.Models;

namespace ProgIce5or6.data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> madeupOptions)
            : base(madeupOptions)
        {
        }

        public DbSet<UserInfo> Users { get; set; }
    }
}