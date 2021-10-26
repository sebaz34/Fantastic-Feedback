using FFFrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FFFrontEnd.Controllers
{
    public class QuestionController : Controller
    {

        HttpClient _client;

        public QuestionController(IHttpClientFactory httpClientFactory)
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

        // GET: QuestionController
        public ActionResult Index()
        {
            if (IsValid())
            {
                var sesh = HttpContext.Session;

                var question = APIRequest<Question>.GetAllRecord(_client, "Question", sesh.GetString("Username"));

                if (question != null)
                {
                    return View(question);
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

        // GET: QuestionController/Details/5
        public ActionResult Details(int id)
        {
            if (IsValid())
            {
                var sesh = HttpContext.Session;

                var question = APIRequest<Question>.GetSingleRecord(_client, "Question", id, sesh.GetString("Username"));

                return View(question);
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }

        // GET: QuestionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: QuestionController/CreateAttachedQuestion
        public ActionResult CreateAttachedQuestion(Question question)
        {
            ViewData["question.SurveyID"] = question.SurveyID;

            return View("Create");
        }

        // POST: QuestionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Question inputQuestion)
        {
            if (IsValid())
            {
                inputQuestion.QuestionID = 0;
                APIRequest<Question>.PostRecord(_client, "Question", inputQuestion);

                return RedirectToAction("Index", "Survey");
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }

        // GET: QuestionController/Edit/5
        public ActionResult Edit(int id)
        {
            if (IsValid())
            {
                var sesh = HttpContext.Session;

                var question = APIRequest<Question>.GetSingleRecord(_client, "Question", id, sesh.GetString("Username"));

                return View(question);
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }

        // POST: QuestionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Question inputQuestion)
        {
            if (IsValid())
            {
                APIRequest<Question>.PutRecord(_client, "Question", id, inputQuestion);

                return RedirectToAction("Index", "Survey");
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }

        // GET: QuestionController/Delete/5
        public ActionResult Delete(int id)
        {
            if (IsValid())
            {
                var sesh = HttpContext.Session;

                var question = APIRequest<Question>.GetSingleRecord(_client, "Question", id, sesh.GetString("Username"));

                return View(question);
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }

        // POST: QuestionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Question inputQuestion)
        {
            if (IsValid())
            {
                APIRequest<Question>.DeleteRecord(_client, "Question", id);

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
