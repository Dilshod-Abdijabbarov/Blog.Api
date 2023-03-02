using Blog.Application.DTOs;
using Blog.Application.DTOs.User;
using Blog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Interfaces
{
  public interface IUserService
    {
        Task<IReadOnlyList<UserDto>> GetAllUserASync();

        Task<UserDto> GetUserIdAsync(int id);

        Task<UserDto> CreateUserAsync(UserCreateDto user);

        Task<UserDto> UpdateUserAsync(UserDto userDto);

        Task DeleteUserAsync(int id);

        Task<BlogDto> CreateBlogAsync(BlogForCreateDto blogDto, int userid);
    }
}
