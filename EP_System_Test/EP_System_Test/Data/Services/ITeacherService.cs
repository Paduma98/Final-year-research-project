using EP_System_Test.Data.Base;
using EP_System_Test.Data.ViewModels;
using EP_System_Test.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EP_System_Test.Data.Services
{
    public interface ITeacherService: IEntityBaseRepository<Teacher>
    {
        //Receive All Teachers

        //Task<IEnumerable<Teacher>> GetAll();
        //Teacher GetById(int id);
        //void Add(Teacher teacher);
        //Teacher Update(int id, Teacher newTeacher);
        //void Delete(int id);

        Task<NewTeacherDropdownsVM> GetNewTeacherDropdownsvalues();
        Task AddNewTeacherAsync(NewTeachersVM data);

        Task<Teacher> GetTeacherByIdAsync(int id);
          
        Task UpdateTeacherAsync(NewTeachersVM data);

    }
}
