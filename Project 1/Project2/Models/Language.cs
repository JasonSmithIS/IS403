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
    [Table("Language")]
    public class Language
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int LanguageId { get; set; }
        [DisplayName("Language Name: ")]
        [StringLength(500, ErrorMessage = "The Language Namr should not exceed 500 characters.")]
        [Required(ErrorMessage = "The Language name is required.")]
        public string LanguageName { get; set; }
    }
}