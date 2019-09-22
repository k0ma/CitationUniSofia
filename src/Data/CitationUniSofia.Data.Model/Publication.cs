namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Publication : BaseModel<int>
    {
        public Publication()
        {
            this.PublicationsMetadata = new HashSet<PublicationMetadata>();
            this.PublicationsAreasScience = new HashSet<PublicationAreaScience>();
            this.PublicationsCitations = new HashSet<PublicationCitation>();
            this.PublicationsAuthors = new HashSet<PublicationAuthor>();
        }

        public string ISSN { get; set; }

        public string ISBN { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }

        public string Title1 { get; set; }

        public string IndexedResource { get; set; }

        public string IndexedResource1 { get; set; }

        public string AlternativeIndexedResource { get; set; }

        public string AlternativeIndexedResource1 { get; set; }

        public string Detail { get; set; }

        public string Summary { get; set; }

        public int? PublicationTypeId { get; set; }
        public virtual PublicationType PublicationType { get; set; }

        public int? LanguageId { get; set; }
        public virtual Language Language { get; set; }

        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }

        public int? InstitutionId { get; set; }
        public virtual Institution Institution { get; set; }
        
        public ICollection<PublicationMetadata> PublicationsMetadata { get; set; }

        public ICollection<PublicationAreaScience> PublicationsAreasScience { get; set; }

        public ICollection<PublicationCitation> PublicationsCitations { get; set; }

        public ICollection<PublicationAuthor> PublicationsAuthors { get; set; }
    }
}


