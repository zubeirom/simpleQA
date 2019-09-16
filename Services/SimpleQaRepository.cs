using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleQa.Entities;
using Microsoft.EntityFrameworkCore;

namespace SimpleQa.Services
{
    public class SimpleQaRepository : ISimpleQaRepository
    {
        private SimpleQaContext _context;

        public SimpleQaRepository(SimpleQaContext context)
        {
            _context = context;
        }

        public bool QuestionExists(int questionId)
        {
            return _context.Question.Any(q => q.Id == questionId);
        }

        public IEnumerable<Question> GetQuestions()
        {
            return _context.Question.OrderBy(q => q.Created).ToList();
        }

        public Question GetQuestion(int questionId)
        {
            return _context.Question.Where(q => q.Id == questionId).FirstOrDefault();
        }
    }
}