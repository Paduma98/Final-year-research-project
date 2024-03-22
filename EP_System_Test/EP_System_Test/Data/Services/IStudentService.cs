using EP_System_Test.Data.Base;
using EP_System_Test.Data.ViewModels;
using EP_System_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Data.Services
{
    public interface IStudentService : IEntityBaseRepository <Students>
    {
        //Receive All Students
        //Task<IEnumerable<Students>> GetAll();
        //Students GetById(int id);
        //void Add(Students student);
        //Students Update(int id, Students newstudent);
        //void Delete(int id);
        Task<Students> GetStudentByIdAsync(int id);
        Task<NewStudentDropdownsVM>GetNewStudentDropdownsvalues();

        Task AddNewStudentAsync(NewStudentsVM data);
        Task UpdateStudentAsync(NewStudentsVM data);
    }
}
