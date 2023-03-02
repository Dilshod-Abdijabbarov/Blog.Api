using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain
{
    public class User : BaseEntity
    {
        public string  FirstName { get; set; }

        public string  LastName { get; set; }

        public string  Address { get; set; }

        public string  UserName { get; set; }

        public string  Password { get; set; }

        public string  Profession { get; set; }

        public IList<Blogs> Blogs { get; set; }

    }
}
