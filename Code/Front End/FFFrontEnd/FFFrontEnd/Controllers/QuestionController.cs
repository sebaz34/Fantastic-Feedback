using FFFrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace FFFrontEnd.Controllers
{
    public class QuestionController : Controller
    {

        HttpClient _client;

        public QuestionController(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("FFHttpClient");
        }

        // GET: QuestionController
        public ActionResult Index()
        {
            var question = APIRequest<Question>.GetAllRecord(_client, "Question");

            return View(question);
        }

        // GET: QuestionController/Details/5
        public ActionResult Details(int id)
        {
            var question = APIRequest<Question>.GetSingleRecord(_client, "Question", id);

            return View(question);
        }

        // GET: QuestionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Question inputQuestion)
        {
            try
            {
                inputQuestion.QuestionID = 0;
                APIRequest<Question>.PostRecord(_client, "Question", inputQuestion);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionController/Edit/5
        public ActionResult Edit(int id)
        {
            var question = APIRequest<Question>.GetSingleRecord(_client, "Question", id);

            return View(question);
        }

        // POST: QuestionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Question inputQuestion)
        {
            try
            {
                APIRequest<Question>.PutRecord(_client, "Question", id, inputQuestion);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionController/Delete/5
        public ActionResult Delete(int id)
        {
            var question = APIRequest<Question>.GetSingleRecord(_client, "Question", id);

            return View(question);
        }

        // POST: QuestionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Question inputQuestion)
        {
            try
            {
                APIRequest<Question>.DeleteRecord(_client, "Question", id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
