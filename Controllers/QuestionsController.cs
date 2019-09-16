using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleQa.Services;
using AutoMapper;
using SimpleQa.Models;

namespace SimpleQa.Controllers
{
    [Route("api/questions")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private ISimpleQaRepository _simpleQa;
        private readonly IMapper _mapper;

        public QuestionsController(ISimpleQaRepository simpleQa, IMapper mapper)
        {
            _simpleQa = simpleQa;
            _mapper = mapper;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            try
            {
                var questions = _simpleQa.GetQuestions();
                var results = _mapper.Map<IEnumerable<QuestionDto>>(questions);
                return Ok(results);
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR: " + e);
                return StatusCode(500, e);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                if(!_simpleQa.QuestionExists(id))
                {
                    return NotFound();
                }

                var question = _simpleQa.GetQuestion(id);
                var result = _mapper.Map<QuestionDto>(question);
                return Ok(result);
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR: " + e.ToString());
                return StatusCode(500, e);
            }
        }
    }
}
