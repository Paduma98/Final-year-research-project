using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Models
{
    public class ApplicationUser:IdentityUser
    {
        //School Information
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }

        [Display(Name = "Email address")]
        public string EmailAddress { get; set; }


        [Display(Name = "Confirm Email")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]

        public string ConfirmPassword { get; set; }


        //TeacherInformation

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Display(Name = "Email address")]
        public string TEmailAddress { get; set; }


        [Display(Name = "Confirm Email")]
        public string TConfirmEmail { get; set; }

        [Display(Name = "Password")]
        public string TPassword { get; set; }

        [Display(Name = "Confirm password")]

        public string TConfirmPassword { get; set; }




        //Student Information

        [Display(Name = "First name")]
        public string SFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string SLastName { get; set; }


        [Display(Name = "Email address")]
        public string SEmailAddress { get; set; }


        [Display(Name = "Confirm Email")]
        public string SConfirmEmail { get; set; }

        [Display(Name = "Password")]
        public string SPassword { get; set; }

        [Display(Name = "Confirm password")]

        public string SConfirmPassword { get; set; }

        //Normal Register

        [Display(Name = "First name")]
        public string UFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string ULastName { get; set; }


        [Display(Name = "Email address")]
        public string UEmailAddress { get; set; }


        [Display(Name = "Confirm Email")]
        public string UConfirmEmail { get; set; }

        [Display(Name = "Password")]
        public string UPassword { get; set; }

        [Display(Name = "Confirm password")]

        public string UConfirmPassword { get; set; }

    }
}
