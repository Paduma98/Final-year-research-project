using EP_System_Test.Models;
using System.Collections.Generic;

namespace EP_System_Test.Data.ViewModels
{
    public class NewStudentDropdownsVM
    {
        public NewStudentDropdownsVM()
        {
            Schools = new List<School>();
            Teachers = new List<Teacher>();
            Sport = new List<Sports>();
            ExtraCurriculars = new List<ExtraCurricular>();
            //Extra = new List<ExtraCurricular> ();



        }
        public List<School> Schools { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<ExtraCurricular> ExtraCurriculars { get; set; }
        public List<Sports> Sport { get; set; }
        //public List<ExtraCurricular> Extra { get; set; }

    }
}
