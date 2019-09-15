using SimpleQa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {
        bool QuestionExists(int questionId);

        IEnumerable<Question> GetQuestions();

        Question GetQuestion(int questionId);

        IEnumerable<Comment> GetComments(int questionId);

        Question GetComment(int questionId, int commentId);

    }
}
