using Blog.Application.DTOs;
using Blog.Application.DTOs.User;
using Blog.Application.Interfaces;
using Blog.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    [Route("api/[User]")]
   // [ApiController]
    public class UserController : ControllerBase
    {
        private readonly  IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userService.GetAllUserASync());
        }

        [HttpGet("id:int")]
        public async Task<ActionResult> GetUser(int id)
        {
            return Ok(await _userService.GetUserIdAsync(id));
        }

        [HttpPost]
        public async Task <ActionResult> CreateUser([FromBody] UserCreateDto user)
        {

            return Created("", await _userService.CreateUserAsync(user));

        }

        [HttpPut]
        public async Task<ActionResult> UpdateUserAsync( UserDto userDto,int id )
        {
            
            if (userDto.id == id)
            {
              await _userService.UpdateUserAsync(userDto);
            }
            return Ok(userDto);
        }

        [HttpDelete]
        public async Task DeleteUserAsync(int id)
        {                       
                await _userService.DeleteUserAsync(id);          
        }


        [HttpPost("id:int/blog")]
        public async Task<ActionResult> PostBlog([FromBody] BlogForCreateDto blogDto,int id)
        {

            return Created("", await _userService.CreateBlogAsync(blogDto,id));

        }
    }
}
