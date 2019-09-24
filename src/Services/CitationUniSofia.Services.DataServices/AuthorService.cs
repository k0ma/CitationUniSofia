namespace CitationUniSofia.Services.DataServices
{
    using CitationUniSofia.Data.Common;
    using CitationUniSofia.Data.Model;
    using CitationUniSofia.Services.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> authorsRepository;

        public AuthorService(IRepository<Author> authorsRepository)
        {
            this.authorsRepository = authorsRepository;
        }
        public IEnumerable<IdAndNameViewModel> GetAll()
        {
            var authors = this.authorsRepository.All().OrderBy(x => x.Name).Select(x => new IdAndNameViewModel
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();

            return authors;
        }
    }
}
