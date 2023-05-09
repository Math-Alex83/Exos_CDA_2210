using ApiUserMoi.Db;
using ApiUserMoi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiUserMoi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserDbContext _context;
        public LoginController()
        {
            _context = new UserDbContext();
        }

        [HttpPost]
        public User? Login(User userToLogin)
        {
            // return new User();
            if ( CheckPassword)
            {
                return _context.Users.FirstOrDefault(u => u.UserName ==
                userToLogin.UserName &&
                u.PassWord == userToLogin.PassWord
                );
            }

        }



    }
}
