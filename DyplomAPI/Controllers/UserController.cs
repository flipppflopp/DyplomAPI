using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.DB_Context;
using DB.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;

namespace DyplomAPI.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : Controller
    {
        private IUserRepository userService;

        public UserController(IUserRepository _userService)
        {
            userService = _userService;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return userService.Get();
        }
        
        [HttpPost]
        public async Task<ActionResult<User>> Add(User? user)
        {
            userService.Add(user);
            
            return NoContent();
        }
        
        [HttpPut]
        public async Task<ActionResult<User>> Update(User user)
        {
            userService.Update(user);
            
            return NoContent();
        }
        
        [HttpDelete]
        public async Task<ActionResult<User>> Remove(User user)
        {
            userService.Remove(user);
            
            return NoContent();
        }
    }
}