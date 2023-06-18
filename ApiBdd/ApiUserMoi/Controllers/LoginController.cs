using ApiUserMoi.Db;
using ApiUserMoi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<User?>> Login(User userToLogin)
        {

            User? user = 
                await _context.Users.FirstOrDefaultAsync(
                u => u.UserName == userToLogin.UserName );

            return _context.Users.FirstOrDefault(u => u.UserName ==
            userToLogin.UserName &&
            u.Password == userToLogin.Password
            );
            

        }



    }
}
