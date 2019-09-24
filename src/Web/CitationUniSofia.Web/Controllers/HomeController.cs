using CitationUniSofia.Data;
using CitationUniSofia.Services.DataServices;
using CitationUniSofia.Services.Models.Publication;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CitationUniSofia.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IPublicationsService publicationsService;

        public HomeController(IPublicationsService publicationsService)
        {
            this.publicationsService = publicationsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Publications()
        {
            var publications = this.publicationsService.GetPublications();

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
