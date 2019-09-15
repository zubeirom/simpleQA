using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleQa.Models
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public ICollection<CommentDto> Comments { get; set; } = new List<CommentDto>();

    }
}
