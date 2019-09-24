namespace CitationUniSofia.Services.DataServices
{
    using System.Collections.Generic;
    using System.Linq;
    using CitationUniSofia.Data.Common;
    using CitationUniSofia.Data.Model;
    using CitationUniSofia.Services.Models;

    public class CitationsService : ICitationsService
    {
        private readonly IRepository<Citation> citationRepository;

        public CitationsService(IRepository<Citation> citationRepository)
        {
            this.citationRepository = citationRepository;
        }

        public IEnumerable<IdAndNameViewModel> GetAll()
        {
            var citations = this.citationRepository.All().OrderBy(x => x.Name).Select(x => new IdAndNameViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            return citations;
        }
    }
}
