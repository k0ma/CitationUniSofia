namespace CitationUniSofia.Services.DataServices
{
    using System.Collections.Generic;
    using System.Linq;
    using CitationUniSofia.Data.Common;
    using CitationUniSofia.Data.Model;
    using CitationUniSofia.Services.Models;

    public class MetadataService : IMetadataService
    {
        private readonly IRepository<Metadata> metadataRepository;

        public MetadataService(IRepository<Metadata> metadataRepository)
        {
            this.metadataRepository = metadataRepository;
        }

        public IEnumerable<IdAndNameViewModel> GetAll()
        {
            var metadata = this.metadataRepository.All().OrderBy(x => x.Name).Select(x => new IdAndNameViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            return metadata;
        }
    }
}
