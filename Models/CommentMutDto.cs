using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleQa.Models
{
    public class CommentMutDto
    {
        [Required(ErrorMessage = "Error:  Required Comment is not provided")]
        [MaxLength(400)]
        public string Content { get; set; }
    }
}