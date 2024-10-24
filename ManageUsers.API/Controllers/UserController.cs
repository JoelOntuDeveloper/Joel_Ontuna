using Data.Entities;
using Data.Interfaces.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManageUsers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("userWithFewerPendingItems")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsersWithFewerPendingItems()
        {

            var users = await _userService.GetUsersWithFewerPendingItems();

            return Ok(users);
        }
    }
}
