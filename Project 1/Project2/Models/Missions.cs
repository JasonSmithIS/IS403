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
    [Table("Missions")]
    public class Missions
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int MissionId { get; set; }
        [DisplayName("Mission Name: ")]
        [Required(ErrorMessage = "A Mission name is required.")]
        [StringLength(50, ErrorMessage = "The mission name cannot exceed 50 characters.")]
        public string MissionName { get; set; }
        [DisplayName("Mission Presidents First Name: ")]
        [Required(ErrorMessage = "A Mission President's First name is required.")]
        [StringLength(50, ErrorMessage = "The Mission President's first name cannot exceed 50 characters.")]
        public string MissionPFName { get; set; }
        [DisplayName("Mission Presidents Last Name: ")]
        [Required(ErrorMessage = "The Mission President's last name is required.")]
        [StringLength(50, ErrorMessage = "The Mission President's last name cannot exceed 50 characters.")]
        public string MissionPLName { get; set; }
        [DisplayName("Address 1: ")]
        [Required(ErrorMessage = "The Mission address is required.")]
        [StringLength(250, ErrorMessage = "The Mission Address must not exceed 250 characters.")]
        public string MissionAddress1 { get; set; }
        [DisplayName("Address 2: ")]
        [StringLength(250, ErrorMessage = "The address 2 line cannot exceed 250 characters.")]
        public string MissionAddress2 { get; set; }
        [DisplayName("City:")]
        [StringLength(160, ErrorMessage = "Your city name cannot exceed 160 characters.")]
        [Required(ErrorMessage = "Please enter the name of your city.")]
        public string MissionCity { get; set; }
        [DisplayName("State:")]
        [Required(ErrorMessage = "Your 2 letter state abbreviation is required.")]
        //Data Integrity State abbreviation
        [StringLength(2, ErrorMessage = "Please enter the two letter abbreviation for your state.")]
        public string MissionState { get; set; }
        [DisplayName("Zip Code:")]
        [Required(ErrorMessage = "Your zip code is required.")]
        //Checks for a zip within a normal range
        [Range(00000, 99999, ErrorMessage = "You zip code is to long. Please enter a valid 5 digit zip code.")]
        public string MissionZip { get; set; }
        [DisplayName("Primary Mission Language: ")]
        public int ? MissionLanguage { get; set; }
        [DisplayName("Mission Climate: ")]
        [StringLength(500, ErrorMessage = "Please reduce your description to less than 500 characters.")]
        public string MissionClimate { get; set; }
        [DisplayName("Dominant Religion: ")]
        [StringLength(250, ErrorMessage = "Make sure that the religion name does not exceed 250 characters")]
        public string MissionReligion { get; set; }
        [DisplayName("Mission Flag: ")]
        [StringLength(500, ErrorMessage ="Please make sure that the file name is less than 500 charachters.")]
        public string MissionFlag { get; set; }
    }
}