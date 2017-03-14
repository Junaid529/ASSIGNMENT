using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class Registration
    {
        public int ID { get; set; }
        public string Full_Name { get; set; }
        public string Email_Address { get; set; }
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm_Password { get; set; }
        public int CountryID { get; set; }
        public virtual Countries TblCountry { get; set; }
        public string Phone_Number { get; set; }
        public int How_You_KnowID { get; set; }
        public virtual HowYouKnow how_you_know { get; set; }
        //public bool IsNewsletter { get; set; }
        //public bool IsAgree { get; set; }
    }
}