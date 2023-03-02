using Blog.Infrastructure.Context;
using Blog.Infrastructure.Interfaces;
using Blog.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Extention
{
   public static   class ServeceRegistration
    {
        public static void AddInfirastructure(this IServiceCollection services,IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer
            (
                configuration.GetConnectionString("DbContextConnection")
            ));

            services.AddScoped(typeof(IGenericRepositoryAsync<>),typeof(GenericRepositoryAsync<>));
            services.AddTransient<IUserRepositoryAsync, UserRepository>();
        }


    }
}
