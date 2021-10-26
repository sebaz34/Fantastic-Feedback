using FFFrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
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

        public bool IsValid()
        {
            var sesh = HttpContext.Session;

            if (!string.IsNullOrEmpty(sesh.GetString("Token")))
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                return true;
            }
            return false;
        }

        // GET: OptionController
        public ActionResult Index()
        {
            if (IsValid())
            {
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
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }

        // GET: OptionController/Details/5
        public ActionResult Details(int id)
        {
            if (IsValid())
            {
                var sesh = HttpContext.Session;

                var option = APIRequest<Option>.GetSingleRecord(_client, "Option", id, sesh.GetString("Username"));

                return View(option);
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
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
            if (IsValid())
            {
                inputOption.OptionID = 0;
                APIRequest<Option>.PostRecord(_client, "Option", inputOption);

                return RedirectToAction("Index", "Survey");
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }

        // GET: OptionController/Edit/5
        public ActionResult Edit(int id)
        {
            if (IsValid())
            {
                var sesh = HttpContext.Session;

                var option = APIRequest<Option>.GetSingleRecord(_client, "Option", id, sesh.GetString("Username"));

                return View(option);
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }

        }

        // POST: OptionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Option inputOption)
        {
            if (IsValid())
            {
                inputOption.OptionVisible = true;

                APIRequest<Option>.PutRecord(_client, "Option", id, inputOption);

                return RedirectToAction("Index", "Survey");
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }

        // GET: OptionController/Delete/5
        public ActionResult Delete(int id)
        {
            if (IsValid())
            {
                var sesh = HttpContext.Session;

                var option = APIRequest<Option>.GetSingleRecord(_client, "Option", id, sesh.GetString("Username"));

                return View(option);
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }

        // POST: OptionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Option inputOption)
        {
            if (IsValid())
            {
                APIRequest<Option>.DeleteRecord(_client, "Option", id);

                return RedirectToAction("Index", "Survey");
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }
    }
}
