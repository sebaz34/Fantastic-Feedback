﻿using FFFrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
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

        // GET: SurveyController
        public ActionResult Index()
        {
            if (IsValid())
            {
                var sesh = HttpContext.Session;

                var survey = APIRequest<Survey>.GetAllRecord(_client, "Survey", sesh.GetString("Username"));

                if (survey != null)
                {
                    return View(survey);
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

        // GET: SurveyController/Details/5
        public ActionResult Details(int id)
        {
            if (IsValid())
            {
                var sesh = HttpContext.Session;

                Survey survey = APIRequest<Survey>.GetSingleRecord(_client, "Survey/details", id, sesh.GetString("Username"));

                if (survey != null)
                {
                    return View(survey);
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


            //SAVING for later reference
            //dynamic mymodel = new ExpandoObject();

            //var survey = APIRequest<Survey>.GetSingleRecord(_client, "Survey", id, sesh.GetString("Username"));

            //var questions = APIRequest<Question>.GetAllRecord(_client, $"Question/QuestionsForSurvey/{id}", sesh.GetString("Username"));

            //foreach (var question in questions)
            //{
            //    question.Options = APIRequest<Option>.GetAllRecord(_client, $"Option/OptionsForQuestion/{question.QuestionID}", sesh.GetString())
            //}
            //mymodel.Survey = survey;
            //mymodel.Questions = questions;


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

                inputSurvey.SurveyID = 0;
                inputSurvey.SurveyCreated = System.DateTime.Now;

                if (IsValid())
                {
                    APIRequest<Survey>.PostRecord(_client, "Survey", inputSurvey);

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                    return RedirectToAction("Login", "Home");
                }
        }

        // GET: SurveyController/Edit/5
        public ActionResult Edit(int id)
        {

            if (IsValid())
            {
                var sesh = HttpContext.Session;

                var survey = APIRequest<Survey>.GetSingleRecord(_client, "Survey", id, sesh.GetString("Username"));

                return View(survey);
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }

        // POST: SurveyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Survey inputSurvey)
        {
            if (IsValid())
            {
                APIRequest<Survey>.PutRecord(_client, "Survey", id, inputSurvey);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }

        // GET: SurveyController/Delete/5
        public ActionResult Delete(int id)
        {
            if (IsValid())
            {
                var sesh = HttpContext.Session;

                var survey = APIRequest<Survey>.GetSingleRecord(_client, "Survey", id, sesh.GetString("Username"));

                return View(survey);
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }

        // POST: SurveyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Survey inputSurvey)
        {
            if (IsValid())
            {
                APIRequest<Survey>.DeleteRecord(_client, "Survey", id);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["RedirectUrl"] = UriHelper.GetEncodedUrl(HttpContext.Request);

                return RedirectToAction("Login", "Home");
            }
        }
    }
}
