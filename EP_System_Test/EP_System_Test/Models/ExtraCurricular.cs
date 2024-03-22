using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Models
{
    public class ExtraCurricular
    {
        [Key]
        public int Id { get; set; }
        public string Society_Name { get; set; }
        //Appointed Teacher

        //Student

        //Relationship

        public List<Students_ExtraCurriculars> Students_Extras { get; set; }

        //Teacher
        public List<Teacher_ExtraCurriculars> ExtraCurriculars_Teachers { get; set; }
        public int ? SchoolId { get; set; }
        [ForeignKey("SchoolId")]
        public School School { get; set; }

        //School
        //public int SchoolId { get; set; }
        //[ForeignKey(nameof(SchoolId))]
        //public School School { get; set; }



        //public string UserDoctorId { get; set; }
        //[ForeignKey(nameof(UserDoctorId))]
        //public ApplicationUser UserDoctor { get; set; }
    }
}
