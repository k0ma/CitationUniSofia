namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class InstitutionType : BaseModel<int>
    {
        public InstitutionType()
        {
            this.Institutions = new HashSet<Institution>();
        }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<Institution> Institutions { get; set; }
    }
}
