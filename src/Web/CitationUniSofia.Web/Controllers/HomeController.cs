using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CitationUniSofia.Data;
using CitationUniSofia.Data.Model;
using CitationUniSofia.Data.Common;
using CitationUniSofia.Web.Models.Publication;

namespace CitationUniSofia.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Publication> publicationsRepository;

        public HomeController(IRepository<Publication> publicationsRepository)
        {
            this.publicationsRepository = publicationsRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Publications()
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

            var publicationViewModel = new PublicationsCollectionViewModel
            {
                Publications = publications
            };

            return View(publicationViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
