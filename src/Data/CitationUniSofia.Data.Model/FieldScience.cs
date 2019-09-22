namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class FieldScience : BaseModel<int>
    {
        public FieldScience()
        {
            this.AreasScience = new HashSet<AreaScience>();
        }

        public string FieldScienceIdentifier { get; set; }

        public string FieldScienceIdentifier1 { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        public string Name1 { get; set; }

        public string EnglishName { get; set; }

        public string EnglishName1 { get; set; }
        
        public ICollection<AreaScience> AreasScience { get; set; }
    }
}
