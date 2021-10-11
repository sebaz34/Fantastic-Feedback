using FFFrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FFFrontEnd.Controllers
{
    public class SurveyController : Controller
    {
        IConfiguration _config;
        HttpClient _client;

        public SurveyController(IConfiguration config)
        {
            _config = config;
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_config["WebApiUrl"]);
        }

        // GET: SurveyController
        public ActionResult Index()
        {
            HttpResponseMessage message = _client.GetAsync("Survey").Result;
            var result = message.Content.ReadAsAsync<List<Survey>>().Result;
            return View(result);
        }

        // GET: SurveyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SurveyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SurveyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SurveyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SurveyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SurveyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SurveyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
