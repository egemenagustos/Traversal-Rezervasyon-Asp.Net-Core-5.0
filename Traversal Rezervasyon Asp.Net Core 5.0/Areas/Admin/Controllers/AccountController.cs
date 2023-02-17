using BusinessLayer.Abstract.AbstractUnitOfWork;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Admin.Models;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel accountViewModel)
        {
            var valueSender = _accountService.TGetById(accountViewModel.SenderID);
            var valuesReceiver = _accountService.TGetById(accountViewModel.ReceiverID);

            valueSender.Balance -= accountViewModel.Amount;
            valuesReceiver.Balance += accountViewModel.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                valueSender,
                valuesReceiver
            };

            _accountService.TMultiUpdate(modifiedAccounts);
            return View();
        }
    }
}
