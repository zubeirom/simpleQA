using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleQa.Models
{
    public class QuestionMutDto
    {
        [Required(ErrorMessage = "Error:  Required title is not provided")]
        [MaxLength(200)]
        public string Title { get; set; }
        
        [MaxLength(400)]
        public string Message { get; set; }
    }
}