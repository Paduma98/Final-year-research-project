using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Models
{
    public class Teacher_Sports
    {

        public int TeacherId { get; set; }
        public Teacher Teachers { get; set; }
        public int SportId { get; set; }
        public Sports Sports { get; set; }
    }
}
