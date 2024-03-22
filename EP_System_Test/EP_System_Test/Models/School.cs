using EP_System_Test.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Models
{
    public class School:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Name of the School")]
        [Required(ErrorMessage ="Please enter the name of the School")]
   
        public string School_Name { get; set; }
        [Display(Name ="Address")]
        [Required(ErrorMessage ="Please enter the Address if your School")]
        public string Address { get; set; }




        public string Email { get; set; }
        public string WhatsApp { get; set; }


        [Display(Name ="City")]
        [Required(ErrorMessage ="Please enter the City correctly")]
        public string City { get; set; }
        [Display(Name = "General Contact Number")]
        [StringLength(12,MinimumLength =10,ErrorMessage ="Pleas eenter 10 digit contact number")]
        public string ContactNumber { get; set; }
        [Display(Name ="Principal's Name")]
        [Required(ErrorMessage ="Enter The Principal's Name")]
        public string Principl_Name { get; set; }

        [Display(Name = "Principal Contact Number")]
        [StringLength(12, MinimumLength = 10, ErrorMessage = "Pleas eenter 10 digit contact number")]
        public string Principal_ContactNumber { get; set; }

        [Display(Name = "Deputy Principal Contact Number")]
        [StringLength(12, MinimumLength = 10, ErrorMessage = "Pleas eenter 10 digit contact number")]
        public string Dep_Principal_Contact { get; set; }

        [Display(Name ="Student Count Grade 06")]
        public int Grade_06_Count { get; set; }
        [Display(Name = "Student Count Grade 07")]
        public int Grade_07_Count { get; set; }
        [Display(Name = "Student Count Grade 08")]
        public int Grade_08_Count { get; set; }
        [Display(Name = "Student Count Grade 09")]
        public int Grade_09_Count { get; set; }
        [Display(Name = "Student Count Grade 10")]
        public int Grade_10_Count { get; set; }
        [Display(Name = "Student Count Grade 11")]
        public int Grade_11_Count { get; set; }
        [Display(Name = "Student Count AL Maths")]
        public int Grade_AL_Maths { get; set; }
        [Display(Name = "Student Count AL Bio")]
        public int Grade_AL_Bio { get; set; }
        [Display(Name = "Student Count AL Commerce")]
        public int Grade_AL_Commerce { get; set; }
        [Display(Name = "Student Count AL Tech")]
        public int Grade_AL_Tech { get; set; }
        [Display(Name = "Student Count AL Arts")]
        public int Grade_AL_Arts { get; set; }

        [Display(Name = "Sports With NO Coachers 01")]
        public int Sports_Coacher_01 { get; set; }

        [Display(Name = "Sports With NO Coachers 02")]
        public int Sports_Coacher_02 { get; set; }

        [Display(Name = "Sports With NO Coachers 03")]
        public int Sports_Coacher_03 { get; set; }

        [Display(Name = "Sports With NO Coachers 04")]
        public int Sports_Coacher_04 { get; set; }

        [Display(Name = "Sports With NO Coachers 05")]
        public int Sports_Coacher_05 { get; set; }

        [Display(Name = "Subjects With NO Teachers 01")]
        public int Subjects_Teachers_01 { get; set; }

        [Display(Name = "Subjects With NO Teachers 02")]
        public int Subjects_Teachers_02 { get; set; }

        [Display(Name = "Subjects With NO Teachers 03")]
        public int Subjects_Teachers_03 { get; set; }

        [Display(Name = "Subjects With NO Teachers 04")]
        public int Subjects_Teachers_04 { get; set; }

        [Display(Name = "Subjects With NO Teachers 05")]
        public int Subjects_Teachers_05 { get; set; }

        [Display(Name = "Total Student Count")]
        public int Student_Count_Total { get; set; }

        [Display(Name ="Teacher Count Total")]
        public int  Teacher_Count_Total { get; set; }


        //[Display(Name = "Verified Certificates")]
        //[Required(ErrorMessage = "Please enter the Link to the Verified Certificate")]

        //Relationships
        public List<Sports> Sports { get; set; }
        public List <ExtraCurricular> ExtraCurriculars{ get; set; }

        public List<Students> School_Students { get; set; }

        public List<Teacher>  School_Teachers{ get; set; }


    }
}
