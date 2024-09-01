using Data.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Post : BaseClass
    {
        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public int AuthorId { get; set; }

        public User Author { get; set; } = null!;
    }
}
