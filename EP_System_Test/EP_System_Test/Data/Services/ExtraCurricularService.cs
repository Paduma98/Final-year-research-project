using EP_System_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Data.Services
{
    public class ExtraCurricularService : IExtraCurricularService
    {
        //Inject the Database
        private readonly AppDbContext _context;
        public ExtraCurricularService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(ExtraCurricular extra)
        {
            _context.Add(extra);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<ExtraCurricular>> GetAll()
        {

            var allExtra = await _context.ExtraCurricualrs.ToListAsync();
            return allExtra;
        }

        public ExtraCurricular GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public ExtraCurricular Update(int id, ExtraCurricular newExtra)
        {
            throw new System.NotImplementedException();
        }
    }
}
