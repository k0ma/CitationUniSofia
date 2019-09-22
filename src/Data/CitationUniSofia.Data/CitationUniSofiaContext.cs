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
        public DbSet<AreaScience> AreasScience { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Metadata> Metadata { get; set; }
        public DbSet<CitationType> CitationTypes { get; set; }
        public DbSet<Citation> Citations { get; set; }
        public DbSet<PublicationType> PublicationTypes { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<PublicationMetadata> PublicationsMetadata { get; set; }
        public DbSet<PublicationCitation> PublicationsCitations { get; set; }
        public DbSet<PublicationAreaScience> PublicationsAreasScience { get; set; }
        public DbSet<AuthorInstitution> AuthorsInstitutions { get; set; }
        public DbSet<PublicationAuthor> PublicationsAuthors { get; set; }

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
                .HasForeignKey(c => c.CitationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<PublicationCitation>()
                .HasOne(pc => pc.Publication)
                .WithMany(p => p.PublicationsCitations)
                .HasForeignKey(p => p.PublicationId);

            builder.Entity<PublicationAreaScience>()
                .HasKey(pfs => new
                {
                    pfs.PublicationId,
                    pfs.AreaScienceId
                });

            builder.Entity<PublicationAreaScience>()
                .HasOne(pas => pas.AreaScience)
                .WithMany(asc => asc.PublicationsAreasScience)
                .HasForeignKey(asc => asc.AreaScienceId);

            builder.Entity<PublicationAreaScience>()
                .HasOne(pfs => pfs.Publication)
                .WithMany(p => p.PublicationsAreasScience)
                .HasForeignKey(p => p.PublicationId);

            builder.Entity<AuthorInstitution>()
                .HasKey(au => new
                {
                    au.AuthorId,
                    au.InstitutionId
                });

            builder.Entity<AuthorInstitution>()
                .HasOne(au => au.Author)
                .WithMany(a => a.AuthorsInstitutions)
                .HasForeignKey(i => i.AuthorId);

            builder.Entity<AuthorInstitution>()
                .HasOne(ai => ai.Institution)
                .WithMany(i => i.AuthorsInstitutions)
                .HasForeignKey(i => i.InstitutionId);

            builder.Entity<PublicationAuthor>()
                .HasKey(pa => new
                {
                    pa.PublicationId,
                    pa.AuthorId
                });

            builder.Entity<PublicationAuthor>()
                .HasOne(pa => pa.Author)
                .WithMany(a => a.PublicationsAuthors)
                .HasForeignKey(a => a.AuthorId);

            builder.Entity<PublicationAuthor>()
                .HasOne(pm => pm.Publication)
                .WithMany(p => p.PublicationsAuthors)
                .HasForeignKey(p => p.PublicationId);            
        }
    }
}
