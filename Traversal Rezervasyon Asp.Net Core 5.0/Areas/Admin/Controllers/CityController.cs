using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.Models;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.GetAll());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
          _destinationService.TAdd(destination);
          var jsonConvert = JsonConvert.SerializeObject(destination);
          return Json(jsonConvert);
        }

        public IActionResult GetById(int DestinationID)
        {
            var values = _destinationService.GetById(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.GetById(id);
            _destinationService.TRemove(values);
            return NoContent();
        }

        [HttpPost]
        public IActionResult UpdateCity(Destination destination)
        {
            destination.Status = true;
            _destinationService.TUpdate(destination);
            var jsonConvert = JsonConvert.SerializeObject(destination);
            return Json(jsonConvert);
        }

    }
}
