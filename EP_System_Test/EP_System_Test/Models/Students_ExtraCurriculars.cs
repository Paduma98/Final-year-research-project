using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Models
{
    public class Students_ExtraCurriculars

    {
        public int StudentId { get; set; }
        public Students Student { get; set; }
        public int ExtraCurricularId { get; set; }
        public ExtraCurricular ExtraCurricular { get; set; }

        //Relationships

    }
}
