using Microsoft.EntityFrameworkCore;
using Vietlott.Api.DataAccess.Entities;

namespace Vietlott.Api.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<DrawGame> DrawGames { get; set; }
        public DbSet<DrawType> DrawTypes { get; set; }
        public DbSet<DrawResult> DrawResults { get; set; }
    }
}
