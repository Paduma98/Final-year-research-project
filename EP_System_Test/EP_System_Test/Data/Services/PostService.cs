using EP_System_Test.Data.Base;
using EP_System_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EP_System_Test.Data.Services
{
    public class PostService : EntityBaseRepository<Post>, IPostService
    {
        public PostService(AppDbContext context) : base(context)
        {
                
        }
    }
}
