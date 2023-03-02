using Blog.Domain;
using Blog.Infrastructure.Context;
using Blog.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class BlogRepositoryAsync :GenericRepositoryAsync<Blogs>, IBlogRepositoryAsync
    {
        private readonly DbSet<Blogs> _blog;

        public BlogRepositoryAsync(ApplicationDbContext context):base(context) 
        {
            _blog = context.Set<Blogs>();
        }

        
    }
}
