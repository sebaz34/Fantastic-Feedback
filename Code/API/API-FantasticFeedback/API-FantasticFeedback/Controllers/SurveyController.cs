using API_FantasticFeedback.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using API_FantasticFeedback.Models.ViewModels;

namespace API_FantasticFeedback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        FFAPIContext _context;

        public SurveyController(FFAPIContext context)
        {
            _context = context;
        }

        //GET: api/<SurveyController>
        //Returns a list of all surveys
        [Authorize]
        [HttpGet("{username}")]
        public IEnumerable<Survey> GetAllSurveys(string username)
        {
            try
            {
                return _context.Surveys.Where(c => c.SurveyCreatorName == username).Where(c => c.SurveyVisible == true).ToList();
            }
            catch (Exception)
            {
                return (IEnumerable<Survey>)StatusCode(500);
            }
        }

        //GET: api/<SurveyController>/details/id
        //Returns survey details, then all questions in survey, then all options for each question
        [Authorize]
        [HttpGet("details/{username}/{id}")]
        public ActionResult<Survey> GetSurveyDetails(string username, int id)
        {
            try
            {

                Survey returnSurvey = _context.Surveys.Where(c => c.SurveyCreatorName == username).Where(c => c.SurveyID == id).Include(c => c.Questions).ThenInclude(c => c.Options).FirstOrDefault();

                if (returnSurvey != null)
                {
                    return returnSurvey;
                }

                return StatusCode(404);
                    
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }

        //GET: api/<SurveyController>/id
        //Returns the specified survey if present
        [Authorize]
        [HttpGet("{username}/{id}")]
        public ActionResult<Survey> GetSingleSurvey(string username, int id)
        {
            Survey returnSurvey;
            try
            {
                try
                {
                    returnSurvey = _context.Surveys.Where(c => c.SurveyCreatorName == username).Where(c => c.SurveyID == id).Where(c => c.SurveyVisible == true).First();
                }
                catch (Exception)
                {
                    return StatusCode(404);
                }
                return returnSurvey;
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //POST: api/<SurveyController>
        //Create a new survey with details passed in
        [Authorize]
        [HttpPost]
        public IActionResult PostSingleSurvey(Survey inputSurvey)
        {
            try
            {
                if (!string.IsNullOrEmpty(inputSurvey.SurveyTitle) && !string.IsNullOrEmpty(inputSurvey.SurveyCreatorName))
                {
                    inputSurvey.SurveyCreated = DateTime.UtcNow;
                    inputSurvey.SurveyVisible = true;
                    _context.Surveys.Add(inputSurvey);
                    _context.SaveChanges();
                    return CreatedAtAction("PostSingleSurvey", inputSurvey);
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //DELETE: api/<SurveyController>/id
        //Changes the surveys visibility status to hidden
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeleteSingleSurvey(int id)
        {
            try
            {
                var survey = _context.Surveys.Find(id);
                if (survey != null)
                {
                    survey.SurveyVisible = false;
                    _context.Surveys.Update(survey);
                    _context.SaveChanges();
                    return Ok(survey);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //DELETE: api/<SurveyController>/<"Undelete">/id
        //Changes the surveys visibility status to visible
        [Authorize]
        [HttpDelete("Undelete/{id}")]
        public IActionResult UndeleteSingleSurvey(int id)
        {
            try
            {
                var survey = _context.Surveys.Find(id);
                if (survey != null)
                {
                    survey.SurveyVisible = true;
                    _context.Surveys.Update(survey);
                    _context.SaveChanges();
                    return Ok(survey);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //PUT:api/<SurveyController>/id
        //Place the provided survey at position provided
        [Authorize]
        [HttpPut("{id}")]
        public ActionResult PutSingleSurvey(int id, Survey inputSurvey)
        {
            try
            {
                if (inputSurvey != null)
                {
                    //Find and delete from context the entry at location id
                    Survey deletedSurvey;
                    deletedSurvey = _context.Surveys.Find(id);
                    _context.Surveys.Remove(deletedSurvey);

                    //Place provided survey at position id
                    inputSurvey.SurveyID = id;
                    _context.Surveys.Add(inputSurvey);

                    //Save Context to DB
                    _context.SaveChanges();

                    return CreatedAtAction("PutSingleSurvey", inputSurvey);
                }
                return StatusCode(400);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //GET: api/<SurveyController>/QuestionsOverTimeReport
        //Provides a list of QuestionsOverTimeViewModel
        [HttpGet("QuestionsOverTimeReport")]
        public ActionResult QuestionsOverTimeReport()
        {
            List<QuestionsOverTimeViewModel> returnReport = new List<QuestionsOverTimeViewModel>();

            foreach (var survey in _context.Surveys.ToList())
            {
                int count = 0;
                DateTime surveyDateTime = survey.SurveyCreated;

                foreach (var question in _context.Questions.Where(c => c.SurveyID == survey.SurveyID))
                {
                    count++;
                }

                returnReport.Add(new QuestionsOverTimeViewModel
                {
                    QuestionCount = count,
                    SurveyCreation = surveyDateTime
                });
            }

            return Ok(returnReport);
        }
    }
}
