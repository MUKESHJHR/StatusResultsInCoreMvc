using Microsoft.AspNetCore.Mvc;
using StatusResultsInCoreMvc.Models;
using System.Diagnostics;

namespace StatusResultsInCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //StatusCodeResult in ASP.NET Core MVC
        //public IActionResult NotFoundExample()
        //{
        //    // Return a 404 Not Found response
        //    return new StatusCodeResult(404);
        //}

        //public IActionResult CustomStatusCodeExample()
        //{
        //    // Return a custom status code
        //    return new StatusCodeResult(403);
        //}

        ////Using StatusCodeResult Helper Method
        //public StatusCodeResult NotFoundExample()
        //{
        //    // Return a 404 Not Found response
        //    return StatusCode(404);
        //}

        //public IActionResult CustomStatusCodeExample()
        //{
        //    // Return a custom status code
        //    return StatusCode(403);
        //}

        //Return a message with status code
        //public IActionResult NotFoundExample()
        //{
        //    return StatusCode(404, new { message = "Resource Not Found" });
        //}
        //public IActionResult CustomStatusCodeExample()
        //{
        //    // Return a custom status code
        //    return StatusCode(403,"Resource Not Found");
        //}

        //HttpUnauthorizedResult in ASP.NET Core MVC
        public IActionResult UnauthorizedExample()
        {
            // Return a 401 Unauthorized response
            //return new UnauthorizedResult();
            // Or use the shorthand helper method:
            return Unauthorized(new {message="You have not access to this page"});
        }

        //NotFoundResult in ASP.NET Core MVC
        public IActionResult NotFoundResult()
        {
            
            return NotFound(new { message = "Resource not found" });
        }

        //OkResult in ASP.NET Core MVC:
        public IActionResult OkResult()
        {
            var jsonData = new { message = "Success" };

            //return Ok( new { message="Success" });

            // Returns a JSON object with a 200 OK response
            return Ok(jsonData);
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
    }
}