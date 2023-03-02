using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.DTOs.User
{
   public  class UserDto : UserCreateDto
    {
        public int id { get; set; }
    }
}
