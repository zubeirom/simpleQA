using SimpleQa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleQa.Services
{
    public interface ISimpleQaRepository
    {
        bool QuestionExists(int questionId);

        IEnumerable<Question> GetQuestions();

        Question GetQuestion(int questionId);

        // IEnumerable<Comment> GetComments(int questionId);

        // Comment GetComment(int questionId, int commentId);

    }
}
