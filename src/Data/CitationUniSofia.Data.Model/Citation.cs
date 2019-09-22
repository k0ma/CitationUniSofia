namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Citation : BaseModel<int>
    {
        public Citation()
        {
            this.PublicationsCitations = new HashSet<PublicationCitation>();
        }

        public int sequence { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        public string Name1 { get; set; }

        public string Year { get; set; }

        public string Detail { get; set; }

        public string Detail1 { get; set; }

        public string Pages { get; set; }

        public int CitationTypeId { get; set; }
        public CitationType CitationType { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public int InstitutionId { get; set; }
        public virtual Institution Institution { get; set; }

        public ICollection<PublicationCitation> PublicationsCitations { get; set; }
    }
}

