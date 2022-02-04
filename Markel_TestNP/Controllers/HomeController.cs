using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Markel_TestNP.Models;
using Markel_TestNP.ViewModels;

namespace Markel_TestNP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MarkelDBContext _markelDBContext;

        public HomeController(ILogger<HomeController> logger, MarkelDBContext markelDBContext)
        {
            _logger = logger;
            _markelDBContext = markelDBContext;
        }

        public IActionResult Index(int? id)
        {
            PageContent pageContentData = GetData(id??1);
            return View(pageContentData);
        }

        public IActionResult Content(int? id)
        {
            PageContent pageContentData = GetData(id);
            return View(pageContentData);
        }

        [HttpGet]
        public IActionResult ContactUs(int? id)
        {
            var pageContentData = GetData(id);
            return View(new ContactUsViewModel() { PageContent = pageContentData });
        }

        [HttpPost]
        public IActionResult ContactUs(int? id, ContactUsViewModel contactUsViewModel)
        {
            var pageContentData = GetData(id);
            contactUsViewModel.PageContent = pageContentData;

            if (ModelState.IsValid)
            {
                ContactUsResponse ContactUsResponse = new ContactUsResponse();
                ContactUsResponse.Name = contactUsViewModel.Name;
                ContactUsResponse.Email = contactUsViewModel.Email;
                ContactUsResponse.Body = contactUsViewModel.Body;
                ContactUsResponse.Subject = contactUsViewModel.Subject;
                ContactUsResponse.ResponseDate = DateTime.Now;
                _markelDBContext.ContactUsResponse.Add(ContactUsResponse);
                 _markelDBContext.SaveChangesAsync();

                return RedirectToAction(nameof(Confirmation));
            }

            return View(contactUsViewModel);
        }

        //Confirmation
        public IActionResult Confirmation()
        {
            return View();
        }

        private PageContent GetData(int? id)
        {
            var pageContentData = _markelDBContext.PageContent.Find(id??-1);
            return pageContentData;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
