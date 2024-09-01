using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Concrete
{
    public class User : BaseClass
    {
        public string FullName { get; set; }

        public string Email { get; set; } = null!;

        //public string UserName { get; set; }

        //public string ImageUrl { get; set; }

        //public byte[] PasswordldSalt { get; set; }

        //public byte[] PasswordldHash { get; set; }


    }
}
