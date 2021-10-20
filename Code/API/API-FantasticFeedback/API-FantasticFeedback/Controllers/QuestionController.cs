using API_FantasticFeedback.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_FantasticFeedback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        FFAPIContext _context;

        public QuestionController(FFAPIContext context)
        {
            _context = context;
        }

        //GET: api/<QuestionController>
        //Returns a list of all questions
        [Authorize]
        [HttpGet("{username}")]
        public IEnumerable<Question> GetAllQuestions(string username)
        {
            try
            {
                return _context.Questions.Where(c => c.QuestionVisible == true).ToList();
            }
            catch (Exception)
            {
                return (IEnumerable<Question>)StatusCode(500);
            }
        }

        //GET: api/<QuestionController>/id
        //Returns the specified question if present
        [Authorize]
        [HttpGet("{username}/{id}")]
        public ActionResult<Question> GetSingleQuestion(string username, int id)
        {
            Question returnQuestion;

            try
            {
                try
                {
                    returnQuestion = _context.Questions.Where(c => c.QuestionID == id).Where(c => c.QuestionVisible == true).First();
                }
                catch (Exception)
                {
                    return StatusCode(404);
                }
                return returnQuestion;
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //GET: api/<QuestionController>/<"QuestionsForSurvey">/id
        //Returns all questions with surveyID value of id
        [Authorize]
        [HttpGet("QuestionsForSurvey/{id}/{username}")]
        public IEnumerable<Question> GetSurveyQuestions(int id, string username)
        {
            IEnumerable<Question> returnIEnum;

            try
            {
                try
                {
                    returnIEnum = _context.Questions.Where(c => c.SurveyID == id).Where(c => c.QuestionVisible == true).ToList();
                }
                catch (Exception)
                {
                    return (IEnumerable<Question>)StatusCode(404);
                }
                return returnIEnum;
            }
            catch (Exception)
            {
                return (IEnumerable<Question>)StatusCode(500);
            }

        }

        //POST: api/<QuestionController>
        //Create a new question with details passed in
        [Authorize]
        [HttpPost]
        public IActionResult PostSingleQuestion(Question inputQuestion)
        {
            try
            {
                if (!string.IsNullOrEmpty(inputQuestion.QuestionText))
                {
                    inputQuestion.QuestionVisible = true;
                    _context.Questions.Add(inputQuestion);
                    _context.SaveChanges();
                    return CreatedAtAction("PostSingleQuestion", inputQuestion);
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        
        //DELETE: api/<QuestionController>/id
        //Changes the questions visibility status to hidden
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeleteSingleQuestion(int id)
        {
            try
            {
                var question = _context.Questions.Find(id);
                if (question != null)
                {
                    question.QuestionVisible = false;
                    _context.Questions.Update(question);
                    _context.SaveChanges();
                    return Ok(question);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //DELETE: api/<QuestionController>/<"Undelete">/id
        //Changes the questions visibility status to visible
        [Authorize]
        [HttpDelete("Undelete/{id}")]
        public IActionResult UndeleteSingleQuestion(int id)
        {
            try
            {
                var question = _context.Questions.Find(id);
                if (question != null)
                {
                    question.QuestionVisible = true;
                    _context.Questions.Update(question);
                    _context.SaveChanges();
                    return Ok(question);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //PUT: api/<QuestionController>/id
        //Place the provided question at the position provided
        [Authorize]
        [HttpPut("{id}")]
        public ActionResult PutSingleQuestion(int id, Question inputQuestion)
        {
            try
            {
                if (inputQuestion != null)
                {
                    //Find and delete from context the entry at location id
                    Question deletedQuestion;
                    deletedQuestion = _context.Questions.Find(id);
                    _context.Questions.Remove(deletedQuestion);

                    //Place provided question at position id
                    inputQuestion.QuestionID = id;
                    _context.Questions.Add(inputQuestion);

                    //Save context changes to DB
                    _context.SaveChanges();

                    return CreatedAtAction("PutSingleQuestion", inputQuestion);
                }
                return StatusCode(400);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
