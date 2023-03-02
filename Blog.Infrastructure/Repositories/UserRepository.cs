using Blog.Domain;
using Blog.Infrastructure.Context;
using Blog.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
   public  class UserRepository : GenericRepositoryAsync<User>,IUserRepositoryAsync
    {
        private readonly DbSet<User> _user;

        public UserRepository(ApplicationDbContext context):base(context)
        {
            _user = context.Set<User>();
        }

        public async  Task<Blogs> CreateBlogAsync(Blogs blog, int id)
        {
            var user = await  _user.Include(user=>user.Blogs).FirstOrDefaultAsync(user => user.id == id);

            if (user is null)
                return null;

            

            user.Blogs.Add(blog);

            await SaveChangesAsync();

            return blog;

        }
    }
}
