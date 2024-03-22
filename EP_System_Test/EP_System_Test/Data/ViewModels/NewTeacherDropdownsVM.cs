using EP_System_Test.Models;
using System.Collections.Generic;

namespace EP_System_Test.Data.ViewModels
{
    public class NewTeacherDropdownsVM
    {
        public NewTeacherDropdownsVM()
        {
            Schools = new List<School>();
            Sportss = new List<Sports>();
            ExtraCurriculars = new List<ExtraCurricular>();


        }
        public List<School> Schools { get; set; }
        public List<Sports> Sportss { get; set; }
        public List<ExtraCurricular> ExtraCurriculars { get; set; }
    }
}
