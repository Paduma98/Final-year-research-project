using EP_System_Test.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace EP_System_Test.Models
{
    public class Post: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }


}
