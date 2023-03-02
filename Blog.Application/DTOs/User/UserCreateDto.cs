using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.DTOs.User
{
   public  class UserCreateDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Profession { get; set; }
    }
}
