using EP_System_Test.Data.Base;
using EP_System_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Data.Services
{
    public interface ISchoolService : IEntityBaseRepository<School>
    {
        //Receive all School
        //Task <IEnumerable<School>> GetAllAsync();
        //Task <School> GetByIdAsync(int id);
        //Task AddAsync(School school);
        //Task<School> UpdateAsync(int id, School newSchool);
        //Task DeleteAsync(int id);

    }
}
