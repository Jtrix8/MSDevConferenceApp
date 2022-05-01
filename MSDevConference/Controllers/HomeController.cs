using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MSDevConference.Models;

namespace MSDevConference.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        [HttpGet]
        public ViewResult RegisterForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RegisterForm(WebinarInvites regisTrationResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(regisTrationResponse);
                return View("ThankYou", regisTrationResponse);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(x => x.WillJoin == true));
        }

        public IActionResult Edit()
        {
            throw new NotImplementedException();
        }

        public IActionResult Details()
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}