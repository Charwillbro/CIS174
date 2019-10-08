using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(25, ErrorMessage = "Maximum length is 25")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Name length must be at least 2 characters but not greater than 25")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Display(Name = "Age")]
        public int Age { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "Maximum length is 100")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        public List<SelectListItem> Countries { get;} = new List<SelectListItem>
        {
            new SelectListItem{Value= "USA", Text="USA"},
            new SelectListItem{Value= "Mexico", Text= "Mexico"},
            new SelectListItem{Value= "Canada", Text="Canada"},
        };
    }

}
