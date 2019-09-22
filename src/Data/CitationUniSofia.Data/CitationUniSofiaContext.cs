namespace CitationUniSofia.Data
{
    using CitationUniSofia.Data.Model;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class CitationUniSofiaContext : IdentityDbContext<CitationUniSofiaUser>
    {
        public CitationUniSofiaContext(DbContextOptions<CitationUniSofiaContext> options)
            : base(options)
        {
        }

        public DbSet<InstitutionType> InstitutionsTypes { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<FieldScience> FieldsSciences { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Metadata> Metadata { get; set; }
        public DbSet<PublicationType> PublicationTypes { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<PublicationMetadata> PublicationsMetadata { get; set; }
        public DbSet<CitationType> CitationTypes { get; set; }
        public DbSet<Citation> Citations { get; set; }
        public DbSet<PublicationCitation> PublicationsCitations { get; set; }
        public DbSet<PublicationFieldScience> PublicationsFieldsSciences { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PublicationMetadata>()
                .HasKey(pm => new
                {
                    pm.PublicationId,
                    pm.MetadataId
                });

            builder.Entity<PublicationMetadata>()
                .HasOne(pm => pm.Metadata)
                .WithMany(m => m.PublicationsMetadata)
                .HasForeignKey(m => m.MetadataId);

            builder.Entity<PublicationMetadata>()
                .HasOne(pm => pm.Publication)
                .WithMany(p => p.PublicationsMetadata)
                .HasForeignKey(p => p.PublicationId);

            builder.Entity<PublicationCitation>()
                .HasKey(pc => new
                {
                    pc.PublicationId,
                    pc.CitationId
                });

            builder.Entity<PublicationCitation>()
                .HasOne(pc => pc.Citation)
                .WithMany(c => c.PublicationsCitations)
                .HasForeignKey(c => c.CitationId);

            builder.Entity<PublicationCitation>()
                .HasOne(pc => pc.Publication)
                .WithMany(p => p.PublicationsCitations)
                .HasForeignKey(p => p.PublicationId);

            builder.Entity<PublicationFieldScience>()
                .HasKey(pfs => new
                {
                    pfs.PublicationId,
                    pfs.FieldScienceId
                });

            builder.Entity<PublicationFieldScience>()
                .HasOne(pfs => pfs.FieldScience)
                .WithMany(fs => fs.PublicationsFieldsScience)
                .HasForeignKey(fs => fs.FieldScienceId);

            builder.Entity<PublicationFieldScience>()
                .HasOne(pfs => pfs.Publication)
                .WithMany(p => p.PublicationsFieldsScience)
                .HasForeignKey(p => p.PublicationId);
        }
    }
}
