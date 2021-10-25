using FFFrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FFFrontEnd.Controllers
{
    public class OptionController : Controller
    {

        HttpClient _client;

        public OptionController(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("FFHttpClient");
        }

        // GET: OptionController
        public ActionResult Index()
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

            var sesh = HttpContext.Session;

            var option = APIRequest<Option>.GetAllRecord(_client, "Option", sesh.GetString("Username"));

            if (option != null)
            {
                return View(option);
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: OptionController/Details/5
        public ActionResult Details(int id)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

            var sesh = HttpContext.Session;

            var option = APIRequest<Option>.GetSingleRecord(_client, "Option", id, sesh.GetString("Username"));

            return View(option);
        }

        // GET: OptionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: OptionController/CreateAttachedOption
        public ActionResult CreateAttachedOption(Option option)
        {
            ViewData["option.QuestionID"] = option.QuestionID;

            return View("Create");
        }

        // POST: OptionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Option inputOption)
        {
            try
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

                inputOption.OptionID = 0;
                APIRequest<Option>.PostRecord(_client, "Option", inputOption);

                return RedirectToAction("Index", "Survey");
            }
            catch
            {
                return View();
            }
        }

        // GET: OptionController/Edit/5
        public ActionResult Edit(int id)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

            var sesh = HttpContext.Session;

            var option = APIRequest<Option>.GetSingleRecord(_client, "Option", id, sesh.GetString("Username"));

            return View(option);
        }

        // POST: OptionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Option inputOption)
        {
            try
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

                APIRequest<Option>.PutRecord(_client, "Option", id, inputOption);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OptionController/Delete/5
        public ActionResult Delete(int id)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

            var sesh = HttpContext.Session;

            var option = APIRequest<Option>.GetSingleRecord(_client, "Option", id, sesh.GetString("Username"));

            return View(option);
        }

        // POST: OptionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Option inputOption)
        {
            try
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

                APIRequest<Option>.DeleteRecord(_client, "Option", id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
