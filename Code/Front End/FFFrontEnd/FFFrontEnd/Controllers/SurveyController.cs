using FFFrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FFFrontEnd.Controllers
{
    public class SurveyController : Controller
    {

        HttpClient _client;

        public SurveyController(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("FFHttpClient");
        }

        // GET: SurveyController
        public ActionResult Index()
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

            var survey = APIRequest<Survey>.GetAllRecord(_client, "Survey");

            return View(survey);
        }

        // GET: SurveyController/Details/5
        public ActionResult Details(int id)
        {
            var survey = APIRequest<Survey>.GetSingleRecord(_client, "Survey", id);

            return View(survey);
        }

        // GET: SurveyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SurveyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Survey inputSurvey)
        {
            try
            {
                inputSurvey.SurveyID = 0;
                inputSurvey.SurveyCreated = System.DateTime.Now;
                APIRequest<Survey>.PostRecord(_client, "Survey", inputSurvey);

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
            var survey = APIRequest<Survey>.GetSingleRecord(_client, "Survey", id);

            return View(survey);
        }

        // POST: SurveyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Survey inputSurvey)
        {
            try
            {
                APIRequest<Survey>.PutRecord(_client, "Survey", id, inputSurvey);

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
            var survey = APIRequest<Survey>.GetSingleRecord(_client, "Survey", id);

            return View(survey);
        }

        // POST: SurveyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Survey inputSurvey)
        {
            try
            {
                APIRequest<Survey>.DeleteRecord(_client, "Survey", id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
