using Microsoft.EntityFrameworkCore;
using SportEvents.Infra;

namespace SportEvents.WebApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }

        internal void InitializeTables(ModelBuilder builder)
        {
            EventsDbContext.InitializeTables(builder);
        }
    }
}
