namespace CitationUniSofia.Web.Models.Publication
{
    using System.Collections.Generic;

    public class PublicationViewModel
    {
        public PublicationViewModel()
        {
            this.PublicationsAuthors = new List<string>();
        }

        public string ISSN { get; set; }

        public string Title { get; set; }

        public string IndexedResource { get; set; }

        public string AlternativeIndexedResource { get; set; }

        public string Detail { get; set; }

        public string Summary { get; set; }

        public string PublicationTypeName { get; set; }

        public string Language { get; set; }

        public string Country { get; set; }

        public string Institution { get; set; }

        public ICollection<string> PublicationsAuthors { get; set; }
    }
}
