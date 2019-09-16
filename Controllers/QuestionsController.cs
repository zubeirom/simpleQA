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

        private QuestionsController(ISimpleQaRepository simpleQa, IMapper mapper)
        {
            _simpleQa = simpleQa;
            _mapper = mapper;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            var questions = _simpleQa.GetQuestions();
            var results = _mapper.Map<IEnumerable<QuestionDto>>(questions);
            return Ok(results);
        }
    }
}
