namespace CitationUniSofia.Web.Controllers
{
    using CitationUniSofia.Services.DataServices;
    using CitationUniSofia.Services.Models.Publication;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Linq;

    public class PublicationsController : BaseController
    {
        private readonly ICitationsService citationsService;
        private readonly IMetadataService metadataService;
        private readonly IAuthorService authorService;

        public PublicationsController(IMetadataService metadataService, IAuthorService authorService, ICitationsService citationsService)
        {
            this.citationsService = citationsService;
            this.metadataService = metadataService;
            this.authorService = authorService;
        }

        [Authorize]
        public IActionResult Create()
        {
            this.ViewData["Authors"] = this.authorService.GetAll()
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                });

            return this.View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(CreatePublicationInputModel inputModel)
        {
            return this.RedirectToAction("Details", new { id = 0 });
        }

        public IActionResult Details(int id)
        {
            return this.View();
        }
    }
}
