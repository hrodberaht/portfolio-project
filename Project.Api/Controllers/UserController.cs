using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Infrastructure;
using Project.Infrastructure.DTO;
using Project.Infrastructure.Services;

namespace Project.Api.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public UserDTO Get(string email){
            return _userService.Get(email);
        }
    }
}