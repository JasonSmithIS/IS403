using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Models
{
    [Table("Questions")]
    public class Questions
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int QuestionId { get; set; }

        [Required(ErrorMessage = "Please enter a question.")]
        [DisplayName("Question: ")]
        [StringLength(5000, ErrorMessage = "Your question must not exceed 5000 characters.")]
        public string Question { get; set; }

        [DisplayName("Answer: ")]
        [StringLength(5000, ErrorMessage = "Your answer must not exceed 5000 characters.")]
        public string Answer { get; set; }

        public int MissionId { get; set; }

        public string UserId { get; set; }
        //won't work until after users model has been created.
        //[ForeignKey("Username")]
        //public virtual int UserId { get; set; }
        //public virtual Users Users { get; set; }
    }
}