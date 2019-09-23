namespace CitationUniSofia.Services.DataServices
{
    using CitationUniSofia.Data.Common;
    using CitationUniSofia.Data.Model;
    using CitationUniSofia.Services.Models.Publication;
    using System.Collections.Generic;
    using System.Linq;

    public class PublicationsService : IPublicationsService
    {
        private readonly IRepository<Publication> publicationsRepository;

        public PublicationsService(IRepository<Publication> publicationsRepository)
        {
            this.publicationsRepository = publicationsRepository;
        }

        public IEnumerable<PublicationViewModel> GetPublications()
        {
            var publications = this.publicationsRepository.All().Select(x => new PublicationViewModel
            {
                ISSN = x.ISSN,
                Title = x.Title,
                IndexedResource = x.IndexedResource,
                AlternativeIndexedResource = x.AlternativeIndexedResource,
                Detail = x.Detail,
                Summary = x.Summary,
                PublicationTypeName = x.PublicationType.Name,
                Language = x.Language.Name,
                Country = x.Country.Name,
                Institution = x.Institution.Name,
                PublicationsAuthors = x.PublicationsAuthors.Select(pa => pa.Author.Name).ToList()
            });

            return publications;
        }
    }

}
