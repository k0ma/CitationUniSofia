namespace CitationUniSofia.Services.DataServices
{
    using CitationUniSofia.Services.Models;
    using System.Collections.Generic;

    public interface IAuthorService
    {
        IEnumerable<IdAndNameViewModel> GetAll();
    }
}
