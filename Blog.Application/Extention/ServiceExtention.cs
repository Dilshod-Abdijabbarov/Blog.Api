using Blog.Application.Interfaces;
using Blog.Application.Profiles;
using Blog.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Extention
{
   public static  class ServiceExtention
    {

        public static void AddAplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingInitializer));

            services.AddTransient<IUserService, UserService>();

           // services.AddTransient<IBlogService, BlogService>();
        }

    }
}
