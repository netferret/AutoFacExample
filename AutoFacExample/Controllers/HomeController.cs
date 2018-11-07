using AutoFacExample.Domain.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoFacExample.Controllers
{
    public class HomeController : Controller
    {
        private IExampleService _exampleService;

        public HomeController(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        public ActionResult Index()
        {
            var result = _exampleService.GetMessage("Welcome to our first example using AutoFac.");
            return View();
        }
        
    }
}