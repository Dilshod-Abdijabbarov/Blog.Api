using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain
{
  public   class BlogAsset : BaseEntity
    {

        public string  FileName { get; set; }

        public int Blogid { get; set; }

        public Blogs Blog { get; }

    }
}
