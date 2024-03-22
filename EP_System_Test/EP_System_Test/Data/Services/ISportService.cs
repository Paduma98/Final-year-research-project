using EP_System_Test.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EP_System_Test.Data.Services
{
    public interface ISportService


    {
        //Get All Sports
        Task<IEnumerable<Sports>> GetAll();

        Sports GetById(int id);
        void Add(Sports sport);
        Sports Update(int id, Sports newSport);
        void Delete(int id);
    }
}
