using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EP_System_Test.Models

    //namespace EP_System_Test.Data.ViewModels
{
    public class NewStudentsVM
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string? Last_Name { get; set; }
        [Display(Name = "Student Address")]
        [Required(ErrorMessage = "Address is Required")]
        public string? Address { get; set; }
        [Display(Name = "Grade")]
        [Required(ErrorMessage = "Student Grade is Required")]
        public string? Stu_Grade { get; set; }

        //Relationships
        [Display(Name = "Sports and ExtraCurricualr Activities")]
        //[Required(ErrorMessage = "Adding Sports are Required")]
        public List<int> SportIds { get; set; }

        //[Display(Name ="Extra Curriculars")]
        ////[Required(ErrorMessage ="Adding Extra Curriculars are Required")]
        //public List<int> ExtraCurricularIds { get; set; }

        [Display(Name ="Teacher")]
        //[Required(ErrorMessage ="Teacher is Required")]
        public List<int> TeacherId { get; set; }

        [Display(Name = "Appointed ExtraCurricualrs")]
        public List<int> ExtraCurricularIds { get; set; }

        [Display(Name ="School")]
        //[Required(ErrorMessage ="School is Required")]
        public int? SchoolId { get; set; }
    }
}
