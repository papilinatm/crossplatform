using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TM_backend.Models;

namespace TM_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public string GetToken ([FromForm] string login, [FromForm] string password)
        {
            var user = SharedData.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user==null)
            {
                Response.StatusCode = 401;
                return "wrong login/password";
            }    
            return AuthOptions.GenerateToken(user.IsAdmin);
        }
        [HttpGet("users")]
        public List<User> GetUsers ()
        {
            return SharedData.Users;
        }
        [HttpGet("token")]
        public string GetToken ()
        {
            return AuthOptions.GenerateToken();
        }
        [HttpGet("token/secret")]
        public string GetAdminToken ()
        {
            return AuthOptions.GenerateToken(true);
        }
    }
}