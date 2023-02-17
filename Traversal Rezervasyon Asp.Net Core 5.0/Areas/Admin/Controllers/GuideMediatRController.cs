using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Commands.GuideCommands;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.CQRS.Queries.GuideQueries;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public GuideMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> GetGuides(int id)
        {
            var values = await _mediator.Send(new GetGuideByIdQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGuide(CreateGuideCommands command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index", "GuideMediatR", new {area = "Admin"});
        }
    }
}
