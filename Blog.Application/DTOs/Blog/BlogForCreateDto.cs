using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.DTOs
{
   public  class BlogForCreateDto
    {

         public string  Title { get; set; }

        public int Topic { get; set; }

        public string  Content { get; set; }

        public int Userid { get; set; }

    }
}
