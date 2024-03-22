using EP_System_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Data.Services
{
    public class SportService : ISportService
    {
        //Inject the Database
        private readonly AppDbContext _context;
        public SportService(AppDbContext context)
        {
                _context = context; 
        }
        public void Add(Sports sport)
        {
            _context.Sports.Add(sport);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Sports>> GetAll()
        {
            var allSports = await _context.Sports.ToListAsync();
            return allSports;
        }

        public Sports GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Sports Update(int id, Sports newSport)
        {
            throw new System.NotImplementedException();
        }
    }
}
