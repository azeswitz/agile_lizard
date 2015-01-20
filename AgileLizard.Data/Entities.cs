using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AgileLizard.Data.Mapping;
using AgileLizard.Domain;

namespace AgileLizard.Data
{
    public partial class Entities : DbContext
    {
        static Entities()
        {
            Database.SetInitializer<Entities>(null);
        }

        public Entities()
            : base("Name=EFDbContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Demo> Demoes { get; set; }

        public DbSet<Highlight> Highlights { get; set; }
        public DbSet<FactRequestType> FactRequestTypes { get; set; }
        public DbSet<FactSetAside> FactSetAsides { get; set; }
        public DbSet<FboProfile> FboProfiles { get; set; }
        public DbSet<Procurement> Procurements { get; set; }
        public DbSet<ProcurementAttachment> ProcurementAttachments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DemoMap());
            modelBuilder.Configurations.Add(new HighlightMap());
            modelBuilder.Configurations.Add(new FactRequestTypeMap());
            modelBuilder.Configurations.Add(new FactSetAsideMap());
            modelBuilder.Configurations.Add(new FboProfileMap());
            modelBuilder.Configurations.Add(new ProcurementMap());
            modelBuilder.Configurations.Add(new ProcurementAttachmentMap());
        }
    }
}
