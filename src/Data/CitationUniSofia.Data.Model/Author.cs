namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Author : BaseModel<int>
    {
        public Author()
        {
            this.PublicationsAuthors = new HashSet<PublicationAuthor>();
            this.Citations = new HashSet<Citation>();
            this.AuthorsInstitutions = new HashSet<AuthorInstitution>();
        }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        public string AuthorIdentifier { get; set; }

        public string AuthorIdentifier1 { get; set; }

        public string AlternativeName { get; set; }

        public string TransliterationName { get; set; }

        public ICollection<PublicationAuthor> PublicationsAuthors { get; set; }

        public ICollection<Citation> Citations { get; set; }

        public ICollection<AuthorInstitution> AuthorsInstitutions { get; set; }
    }
}
