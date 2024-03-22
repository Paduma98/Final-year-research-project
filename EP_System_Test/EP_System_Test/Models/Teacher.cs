using EP_System_Test.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Models
{
    public class Teacher : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }
        public string WhatsApp { get; set; }

        [Display(Name = "First Name")]
        public string  FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Grade_Teaching")]
        public string Grade_Teaching { get; set; }
        [Display(Name = "NIC")]
        public string NIC { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Contact Number")]
        [StringLength(12,MinimumLength =10,ErrorMessage ="Please enter 10 digit contact number")]
        public string Contact_Number { get; set; }

        [Display(Name = "Teacher Number")]
        public string Teacher_Number { get; set; }

        [Display(Name ="Appointed as a Class Teacher ?")]
        public bool ClassTeacher { get; set; }
        [Display(Name ="Teaching Subject")]
        public string Teaching_Subject { get; set; }

        [Display(Name ="Appointed Sport")]
        public string Appointed_Sports { get; set; }

        //Relationship

        //Sports

        //public List<Sports> Teacher_Sports { get; set; }


        //ExtraCurricular
        // public List<ExtraCurricular> Teacher_ExtraCurricular { get; set; }
        public List<Teacher_ExtraCurriculars> Teachers_ExtraCurriculars  { get; set; }

        //Sports

        public List<Teacher_Sports> Teachers_Sports { get; set; }

        //Students 

        public List<Student_Teacher> Teachers_Students { get; set; }
        // public List<Students> Teach_Students { get; set; }

        //School

        public int? SchoolId { get; set; }

        [ForeignKey("SchoolId")]
        public School School { get; set; }


    }
}
