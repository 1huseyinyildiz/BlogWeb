using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Concrete
{
    public class Comment : BaseClass
    {
        public string Text { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
