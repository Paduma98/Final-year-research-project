using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EP_System_Test.Models
{
    public class NewTeachersVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Grade_Teaching")]
        public string Grade_Teaching { get; set; }
        [Display(Name = "NIC")]
        public string NIC { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Contact Number")]
        [StringLength(12, MinimumLength = 10, ErrorMessage = "Please enter 10 digit contact number")]
        public string Contact_Number { get; set; }

        [Display(Name = "Teacher Number")]
        public string Teacher_Number { get; set; }

        [Display(Name = "Appointed as a Class Teacher ?")]
        public bool ClassTeacher { get; set; }
        [Display(Name = "Teaching Subject")]
        public string Teaching_Subject { get; set; }

        [Display(Name = "Appointed Sport")]
        public string Appointed_Sports { get; set; }

        [Display(Name ="Appointed Sports")]
        public List<int> SportIds { get; set; }

        [Display(Name ="Appointed ExtraCurricualrs")]
        public List<int> ExtraCurricularIds { get; set; }

        [Display(Name ="School")]

        public int SchoolId { get; set; }
    }
}
