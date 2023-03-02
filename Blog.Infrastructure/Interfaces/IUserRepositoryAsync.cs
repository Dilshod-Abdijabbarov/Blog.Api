using Blog.Domain;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Interfaces
{
    public  interface IUserRepositoryAsync : IGenericRepositoryAsync<User>
    {
        Task<Blogs> CreateBlogAsync(Blogs blog, int id);
    }
}
