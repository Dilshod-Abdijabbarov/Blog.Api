using AutoMapper;
using Blog.Application.DTOs;
using Blog.Application.DTOs.User;
using Blog.Application.Interfaces;
using Blog.Domain;
using Blog.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepositoryAsync _userRepository;

        private readonly IMapper _mapper;

        public UserService(IUserRepositoryAsync userRepository,IMapper mapper)
        {
            _userRepository = userRepository;

            _mapper = mapper;
        }

        public async  Task<BlogDto> CreateBlogAsync(BlogForCreateDto blogDto, int userid)
        {
            return _mapper.Map<BlogDto>(await _userRepository.CreateBlogAsync(_mapper.Map<Blogs>(blogDto),userid));
        }

        public async  Task<UserDto> CreateUserAsync(UserCreateDto userDto)
        {

            var users = _mapper.Map<User>(userDto);

            return _mapper.Map<UserDto>(await _userRepository.AddAsync(users));

        }

        public async  Task DeleteUserAsync(int id)
        {
        
             await _userRepository.DeleteAsync(id);
        }

        public async  Task<IReadOnlyList<UserDto>> GetAllUserASync()
        {
            return _mapper.Map<IReadOnlyList<UserDto>>(await _userRepository.GetAllAsync());
        }

        public async  Task<UserDto> GetUserIdAsync(int id)
        {
            return _mapper.Map<UserDto>(await _userRepository.GetByidAsync(id));
        }

        public async  Task<UserDto> UpdateUserAsync(UserDto userDto)
        {
                    
            var users = _mapper.Map<User>(userDto);

            return _mapper.Map<UserDto>(await _userRepository.UpdateAsync(users));
            
        }

     
    }
}
