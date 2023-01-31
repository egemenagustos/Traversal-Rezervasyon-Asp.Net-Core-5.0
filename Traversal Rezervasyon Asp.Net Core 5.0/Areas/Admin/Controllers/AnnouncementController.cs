using AutoMapper;
using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Admin.Models;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.GetAll());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDto model)
        {
            if(ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement()
                {
                    Content= model.Content,
                    Title =model.Title,
                    Date = DateTime.Parse(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Index", "Announcement", new { area = "Admin" });
            }
            return View(model);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.GetById(id);
            _announcementService.TRemove(values);
            return RedirectToAction("Index", "Announcement", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var idValue = _mapper.Map<AnnouncementUpdateDto>(_announcementService.GetById(id));
            return View(idValue);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDto model)
        {
            if(ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementID = model.AnnouncementID,
                    Title = model.Title,
                    Content = model.Content,
                    Date = DateTime.Parse(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index", "Announcement", new { area = "Admin" });
            }
            return View(model);
        }
           
    }
}
