using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CitationUniSofia.Services.Models.Publication
{
    public class CreatePublicationInputModel
    {
        public CreatePublicationInputModel()
        {
            this.PublicationsAuthors = new List<int>();
            this.PublicationsCitations = new List<int>();
            this.PublicationsMetadata = new List<int>();
        }

        public string ISSN { get; set; }
        
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

        public int PublicationTypeId { get; set; }

        [Display(Name = "Език")]
        public int LanguageId { get; set; }

        public int CountryId { get; set; }

        public int InstitutionId { get; set; }

        public int AreasScienceId { get; set; }

        public int FieldScienceId { get; set; }

        public ICollection<int> PublicationsMetadata { get; set; }

        public ICollection<int> PublicationsCitations { get; set; }

        public ICollection<int> PublicationsAuthors { get; set; }
    }
}
