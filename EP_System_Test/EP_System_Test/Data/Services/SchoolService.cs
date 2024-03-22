using EP_System_Test.Data.Base;
using EP_System_Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Data.Services
{
    public class SchoolService : EntityBaseRepository<School>, ISchoolService
    {
        public SchoolService(AppDbContext context) : base(context) { }
    }
}
