using FFFrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FFFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        HttpClient _client;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _client = httpClientFactory.CreateClient("FFHttpClient");
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: login
        public IActionResult Login()
        {
            ViewData["Error"] = null;
            return View();
        }

        // POST: login
        [HttpPost]
        public IActionResult Login(UserInfo userinfo)
        {
            HttpResponseMessage result = _client.PostAsJsonAsync("Token/GenerateToken", userinfo).Result;

            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.BadRequest:
                    ViewData["Error"] = "Invalid Login Details";
                    return View();
                case System.Net.HttpStatusCode.OK:
                    //Retrieve token from body
                    string token = result.Content.ReadAsStringAsync().Result;
                    //Session management
                    //Use session state managment in example from week 10 - bsb and acc no

                    //placeholder return
                    return View();
                    break;
                default:
                    ViewData["Error"] = "Something Went Wrong - Try Again";
                    _logger.LogError("Error logging in, default statment in switch", result.ReasonPhrase);
                    return View();
            }
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
