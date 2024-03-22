using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Models
{
    public class Teacher_ExtraCurriculars


    {
        public int TeacherId { get; set; }
        public Teacher Teachers { get; set; }
        public int ExtraCurricualrId { get; set; }
        public ExtraCurricular ExtraCurriculars { get; set; }
    }
}
