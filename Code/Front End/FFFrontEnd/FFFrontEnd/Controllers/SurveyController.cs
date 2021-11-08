using FFFrontEnd.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FFFrontEnd.Models.ViewModels;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace FFFrontEnd.Controllers
{
    public class SurveyController : Controller
    {
        //Global Variables
        HttpClient _client;
        IWebHostEnvironment _env;

        public SurveyController(IHttpClientFactory httpClientFactory, IWebHostEnvironment env)
        {
            _client = httpClientFactory.CreateClient("FFHttpClient");
            _env = env;
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

        //File Upload
        //Used with survey logo image
        public async Task<IActionResult> UploadFileLocally(IFormFile file)
        {
            try
            {
                if (file.Length>0)
                {
                    string folderRoot = Path.Combine(_env.ContentRootPath, "wwwroot\\Uploads");
                    string fileName = file.FileName;
                    string filePath = Path.Combine(folderRoot, fileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
                return Ok(new { success = true, message = "File Successfully Uploaded" });
            }
            catch (Exception e)
            {
                return BadRequest(new { success = false, message = $"File failed to upload - Error occured within UploadFileLocally() - {e}" });
            }
        }

        //File Export
        //Used within survey details view

        //public sealed class FooMap : ClassMap<Survey>
        //{
        //    public FooMap()
        //    {
        //        Map(m => m.SurveyID);
        //        Map(m => m.SurveyTitle);
        //        Map(m => m.SurveyTopic);
        //        Map(m => m.SurveyCreatorName);
        //        Map(m => m.SurveyCreated);
        //        Map(m => m.SurveyComments);
        //        Map(m => m.SurveyImage);
        //        Map(m => m.SurveyImage);

        //        Map(m => m.Questions);
        //    }
        //}

        public IActionResult ExportSurvey(Survey survey)
        {

            dynamic exportList = new ExpandoObject();

            //List<Survey> exportList = new List<Survey>();

            //exportList.Add(survey);

            if (IsValid())
            {
                var sesh = HttpContext.Session;

                List<Question> questions = new List<Question>();
                questions.AddRange(APIRequest<Question>.GetAllRecord(_client, $"Question/QuestionsForSurvey/{survey.SurveyID}", sesh.GetString("Username")));
                    

                List<Option> options = new List<Option>();

                foreach (var question in questions)
                {
                    options.AddRange(APIRequest<Option>.GetAllRecord(_client, $"Option/OptionsForQuestion/{question.QuestionID}", sesh.GetString("Username")));
                }

                exportList.Survey = survey;
                exportList.Questions = questions;
                exportList.Options = options;
            }

            var stream = new MemoryStream();

            using (var writer = new StringWriter())
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(exportList);

                //writer.ToString().Dump();
            }

            //using (var writeFile = new StreamWriter(stream, leaveOpen: true))
            //{
            //    var csv = new CsvWriter(writeFile, CultureInfo.CurrentCulture, true);
            //    csv.WriteRecords(exportList);
            //}

            stream.Position = 0;

            return File(stream, "application/octet-stream", $"{survey.SurveyTitle}_{DateTime.Now.ToString("ddMMM_HHmmss")}.csv");
        }
    }
}
