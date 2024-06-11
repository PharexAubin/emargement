using ApiPointeur.Models;
using ListpresenceMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq;

namespace ListpresenceMvc.Controllers
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
        public IActionResult Classe()
        {
            return View();
        }
        public async Task<IActionResult> Etudiant()
        {
            List<Eleve> Eleves = new List<Eleve>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7295/api/Eleves"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Eleves = JsonConvert.DeserializeObject<List<Eleve>>(apiResponse);
                }
            }




            ViewData["Eleves"] = Eleves;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}