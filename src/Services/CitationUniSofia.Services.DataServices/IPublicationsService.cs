namespace CitationUniSofia.Services.DataServices
{
    using CitationUniSofia.Services.Models.Publication;
    using System.Collections.Generic;

    public interface IPublicationsService
    {
        IEnumerable<PublicationViewModel> GetPublications();
    }
}
