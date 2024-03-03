using Microsoft.AspNetCore.Mvc;
using STLViewer.Models;
using System.Diagnostics;

namespace STLViewer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string stlFilePath = "/Stlimage/Wolf_One_stl.stl"; // Adjust this to your actual file path

            // Construct the absolute file path
            string wwwRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            string absoluteStlFilePath = Path.Combine(wwwRootPath, stlFilePath.TrimStart('/'));

            // Check if the file exists
            if (!System.IO.File.Exists(absoluteStlFilePath))
            {
                return NotFound();
            }

            // Pass the file path to the view
            ViewData["StlFilePath"] = absoluteStlFilePath;

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
        }*/

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Index(IFormFile file)
        //{
        //    if (file != null && file.Length > 0)
        //    {
        //        using (var memoryStream = new MemoryStream())
        //        {
        //            await file.CopyToAsync(memoryStream);
        //            var fileBytes = memoryStream.ToArray();
        //            string base64 = Convert.ToBase64String(fileBytes);
        //            return RedirectToAction("Privacy", new { modelData = base64 });
        //        }
        //    }
        //    return View();
        //}
    }
}