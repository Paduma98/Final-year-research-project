using EP_System_Test.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EP_System_Test.Data.Services
{
    public interface IExtraCurricularService


    {
        //Get All Sports
        Task<IEnumerable<ExtraCurricular>> GetAll();

        ExtraCurricular GetById(int id);
        void Add(ExtraCurricular extra);
        ExtraCurricular Update(int id, ExtraCurricular newExtra);
        void Delete(int id);
    }
}
