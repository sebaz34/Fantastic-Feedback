using ChartJSCore.Models;
using FFFrontEnd.Models;
using FFFrontEnd.Models.ViewModels;
using Microsoft.AspNetCore.Http;
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
            HttpResponseMessage response = _client.GetAsync("Survey/QuestionsOverTimeReport").Result;

            var questionsOverTimeVM = response.Content.ReadAsAsync<List<QuestionsOverTimeViewModel>>().Result;

            var chartLabels = questionsOverTimeVM.Select(c => c.SurveyCreation.ToShortDateString()).ToList();

            var numberOfQuestions = questionsOverTimeVM.Select(c => (double?)c.QuestionCount).ToList();

            Chart questionsOverTimeChart = new Chart();

            questionsOverTimeChart.Type = Enums.ChartType.Line;

            ChartJSCore.Models.Data data = new ChartJSCore.Models.Data();

            data.Labels = chartLabels;

            LineDataset dataset = new LineDataset()
            {
                Label = "Number of Questions per Survey over Time",
                Data = numberOfQuestions,
                Type = Enums.ChartType.Line
            };

            data.Datasets = new List<Dataset>();
            data.Datasets.Add(dataset);

            questionsOverTimeChart.Data = data;

            ViewData["Graph"] = questionsOverTimeChart;

            return View(questionsOverTimeChart);
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
                    var sesh = HttpContext.Session;
                    sesh.SetString("Token", token);
                    sesh.SetString("Username", userinfo.Username);
                    if (TempData.Peek("RedirectUrl") != null)
                    {
                        string redirect = TempData["RedirectUrl"].ToString();
                        return Redirect(redirect);
                    }
                    else
                    {
                        //Return home
                        return RedirectToAction("Index", "Home");
                    }


                default:
                    ViewData["Error"] = "Something Went Wrong - Try Again";
                    _logger.LogError("Error logging in, default statment in switch", result.ReasonPhrase);
                    return View();
            }
        }

        public IActionResult Logout()
        {
            var sesh = HttpContext.Session;
            sesh.SetString("Token", "");
            return RedirectToAction("Index", "Home");
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
