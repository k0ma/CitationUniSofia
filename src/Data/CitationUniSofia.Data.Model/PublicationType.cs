namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class PublicationType : BaseModel<int>
    {
        public PublicationType()
        {
            this.Publications = new HashSet<Publication>();
        }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<Publication> Publications { get; set; }
    }
}
