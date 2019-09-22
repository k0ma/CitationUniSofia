namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Metadata : BaseModel<int>
    {
        public Metadata()
        {
            this.PublicationsMetadata = new HashSet<PublicationMetadata>();
        }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<PublicationMetadata> PublicationsMetadata { get; set; }
    }
}
