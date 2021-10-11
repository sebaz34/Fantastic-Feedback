using API_FantasticFeedback.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        [HttpGet]
        public IEnumerable<Survey> GetAll()
        {
            return _context.Surveys.ToList();
        }

        //GET: api/<SurveyController>/id
        [HttpGet("{id}")]
        public ActionResult<Survey> GetSingle(int id)
        {
            return _context.Surveys.Include(c => c.SurveyID).Where(c => c.SurveyID == id).FirstOrDefault();
        }
    }
}
