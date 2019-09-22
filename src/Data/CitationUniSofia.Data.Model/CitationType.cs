namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CitationType : BaseModel<int>
    {
        public CitationType()
        {
            this.Citations = new HashSet<Citation>();
        }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<Citation> Citations { get; set; }
    }
}
