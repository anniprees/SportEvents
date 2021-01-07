using Microsoft.EntityFrameworkCore;
using SportEvents.Data;

namespace SportEvents.Infra
{
    public class EventsDbContext : DbContext
    {
        public EventsDbContext(DbContextOptions<EventsDbContext> options)
            : base(options) { }

        public DbSet<EventData> Events { get; set; }
        public DbSet<EventRegistrationData> Registrations { get; set; }
        public DbSet<ParticipantData> Participants { get; set; }
        public DbSet<SportsCategoryData> SportsCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            InitializeTables(b);
        }

        public static void InitializeTables(ModelBuilder b)
        {
            b.Entity<EventData>().ToTable(nameof(Events));
            b.Entity<EventRegistrationData>().ToTable(nameof(Registrations))
                .HasKey(x => new {x.EventId, x.ParticipantId});
            b.Entity<ParticipantData>().ToTable(nameof(Participants));
            b.Entity<SportsCategoryData>().ToTable(nameof(SportsCategories));
        }
    }
}
