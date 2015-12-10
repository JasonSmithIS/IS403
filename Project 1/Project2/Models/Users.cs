using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
//using System.Web.Mvc;

namespace Project2.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [DisplayName("Email:")]
        //Email validation which checks for an @ sign and a . with 2 - 4 alphanumeric characters after
        [Required(ErrorMessage = "Please enter your email address.")]
        [RegularExpression(@"[A-Za-z0-9.​_%+-]+@[A-Za-z0-9._​%+-]+\.[A-Za-z]{2,4}", ErrorMessage = "Your email is not valid. Please reenter a valid email address.")]
        public String UserId { get; set; }
        [DisplayName("Password: ")]
        [Required(ErrorMessage = "Please enter your password.")]
        [StringLength(50, ErrorMessage = "Your password must not exceed 50 characters.")]
        public string UserPassword { get; set; }
        [DisplayName("First Name: ")]
        [Required(ErrorMessage = "Please enter your first name.")]
        [StringLength(50,ErrorMessage = "Your first name must not exceed 50 characters.")]
        public string UserFName { get; set; }
        [DisplayName("Last Name: ")]
        [Required(ErrorMessage = "Your Last Name is required.")]
        [StringLength(50, ErrorMessage = "Your last name must not exceed 50 characters.")]
        public string UserLName { get; set; }
        [DisplayName("Profile Picture: ")]
        [StringLength(250, ErrorMessage = "Please make sure that your image link is not longer than 250.")]
        public string UserImage { get; set; }
        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        //[Compare("UserPassword", ErrorMessage = "The password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }
    }
}