using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetmvc.Models;
using Microsoft.Extensions.Options;

namespace aspnetmvc.Controllers
{
    public class HomeController : Controller
    {
        protected ProjectOwners projectOwners;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        public HomeController(IOptions<ProjectOwners> settings)
        {
            projectOwners = settings?.Value;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.ProjectOwner = projectOwners.ProjectOwner;
            ViewBag.ProjectOwnerHref = projectOwners.ProjectOwnerHref;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
