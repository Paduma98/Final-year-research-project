using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Models
{
    public class Sports
    {
        [Key]
        public int Id { get; set; }
        public string Sport_Name { get; set; }
        //Appointed Teacher

        //Student


        //Relationships
        public List<Students_Sports> Student_Sports { get; set; }

        //Teacher
       // public int TeacherId { get; set; }
        //[ForeignKey("TeacherId")]
//        public Teacher TeacherSports { get; set; }

        public List<Teacher_Sports> Sports_Teachers { get; set; }

        //School
        public int? SchoolId { get; set; }
        [ForeignKey("SchoolId")]
        public School School { get; set; }
    }
}
