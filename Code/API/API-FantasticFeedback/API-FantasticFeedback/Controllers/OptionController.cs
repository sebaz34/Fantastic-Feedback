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
    public class OptionController : ControllerBase
    {
        FFAPIContext _context;

        public OptionController(FFAPIContext context)
        {
            _context = context;
        }

        //GET: api/<OptionController>
        //Returns a list of all options
        [Authorize]
        [HttpGet]
        public IEnumerable<Option> GetAllOptions()
        {
            try
            {
                return _context.Options.Where(c => c.OptionVisible == true).ToList();
            }
            catch (Exception)
            {
                return (IEnumerable<Option>)StatusCode(500);
            }
        }

        //GET: api/<OptionController>/id
        //Returns the specified option if present
        [Authorize]
        [HttpGet("{username}/{id}")]
        public ActionResult<Option> GetSingleOption(string username, int id)
        {
            Option returnOption;

            try
            {
                try
                {
                    returnOption = _context.Options.Where(c => c.OptionID == id).Where(c => c.OptionVisible == true).First();
                }
                catch (Exception)
                {
                    return StatusCode(404);
                }
                return returnOption;
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //GET: api/<OptionController>/<"OptionsForQuestion">/id
        //Returns all options with QuestionID value of id
        [Authorize]
        [HttpGet("OptionsForQuestion/{id}/{username}")]
        public IEnumerable<Option> GetQuestionOptions(int id, string username)
        {
            IEnumerable<Option> returnIEnum;

            try
            {
                try
                {
                    returnIEnum = _context.Options.Where(c => c.QuestionID == id).Where(c => c.OptionVisible == true).ToList();
                }
                catch (Exception)
                {
                    return (IEnumerable<Option>)StatusCode(404);
                }
                return returnIEnum;
            }
            catch (Exception)
            {
                return (IEnumerable<Option>)StatusCode(500);
            }
        }

        //POST: api/<OptionController>
        //Create a new Option with details passed in
        [Authorize]
        [HttpPost]
        public IActionResult PostSingleOption(Option inputOption)
        {
            try
            {
                if (!string.IsNullOrEmpty(inputOption.OptionText))
                {
                    inputOption.OptionVisible = true;
                    _context.Options.Add(inputOption);
                    _context.SaveChanges();
                    return CreatedAtAction("PostSingleOption", inputOption);
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //DELETE: api/<OptionController>/id
        //Changes the options visibility status to hidden
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeleteSingleOption(int id)
        {
            try
            {
                var option = _context.Options.Find(id);
                if (option != null)
                {
                    option.OptionVisible = false;
                    _context.Options.Update(option);
                    _context.SaveChanges();
                    return Ok(option);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //DELETE: api/<OptionController>/<"Undelete">/id
        //Changes the options visibility status to visible
        [Authorize]
        [HttpDelete("Undelete/{id}")]
        public IActionResult UndeleteSingleOption(int id)
        {
            try
            {
                var option = _context.Options.Find(id);
                if (option != null)
                {
                    option.OptionVisible = true;
                    _context.Options.Update(option);
                    _context.SaveChanges();
                    return Ok(option);
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
        public ActionResult PutSingleOption(int id, Option inputOption)
        {
            try
            {
                if (inputOption != null)
                {
                    //Find and delete from context the entry at location id
                    Option deletedOption;
                    deletedOption = _context.Options.Find(id);
                    _context.Options.Remove(deletedOption);

                    //Place provided option at position id
                    inputOption.OptionID = id;
                    _context.Options.Add(inputOption);

                    //Save context changes to DB
                    _context.SaveChanges();

                    return CreatedAtAction("PutSingleOption", inputOption);
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
