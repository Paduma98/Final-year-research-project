using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Models
{
    public class Students_Sports
    {
        public int StudentId { get; set; }
        public Students Student { get; set; }
        public int SportsId { get; set; }
        public Sports Sports { get; set; }
    }
}
