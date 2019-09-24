namespace CitationUniSofia.Services.DataServices
{
    using CitationUniSofia.Services.Models;
    using System.Collections.Generic;

    public interface IMetadataService
    {
        IEnumerable<IdAndNameViewModel> GetAll();
    }
}
