using EP_System_Test.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Models
{
    public class Students:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string WhatsApp { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Date of Birth - YYYY/MM/DD ")]
        public string DOB { get; set; }

        [Display(Name = "Grade")]
        public string Stu_Grade { get; set; }

        [Display(Name = "Mother's Name")]
        public string Mothers_Name { get; set; }

        [Display(Name = "Mother's Contact Number")]
        public string Mother_Contact_Number { get; set; }

        [Display(Name = "Mother's Occuapation")]
        public string Mother_Occupation { get; set; }


        [Display(Name = "Father Name")]
        public string FatherName { get; set; }

        [Display(Name = "Father's Contact Number")]
        [StringLength(12,MinimumLength =10,ErrorMessage ="Please enter 10 digit number")]
        public string Father_Contact_Number { get; set; }

        [Display(Name = "Father's Occupation")]
        public string Father_Occupation { get; set; }

        //Class Teacher

        //Relationships

        //public List<Sports> StuSports { get; set; }
       // public List <ExtraCurricular> StuExtraCurriculars{ get; set; }

        public List <Students_ExtraCurriculars> StuExtraCurriculars { get; set; }
        public List <Students_Sports> Stu_Sports{ get; set; }

       // School
        public int? SchoolId { get; set; }

        [ForeignKey("SchoolId")]
        public School School { get; set; }

        //Teacher
        public List<Student_Teacher> Students_Teachers { get; set; }
        //public int TeacherId { get; set; }
        //[ForeignKey("TeacherId")]
        //public Teacher Teacher_Stu { get; set; }
    }
}
