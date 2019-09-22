using CitationUniSofia.Data.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CitationUniSofia.Data.Model
{
    public class Institution : BaseModel<int>
    {
        public Institution()
        {
            this.Publications = new HashSet<Publication>();
            this.Citations = new HashSet<Citation>();
        }

        public string Identifier { get; set; }

        public string Identifier1 { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        public string Name1 { get; set; }

        public string AlternativeName { get; set; }

        public string AlternativeName1 { get; set; }

        public string TransliterationName { get; set; }

        public string TransliterationName1 { get; set; }

        public string WWW { get; set; }

        public string Address { get; set; }

        public string TransliterationAddress { get; set; }

        public int InstitutionTypeId { get; set; }
        public virtual InstitutionType InstitutionType { get; set; }

        public ICollection<Publication> Publications { get; set; }

        public ICollection<Citation> Citations { get; set; }

    }
}

