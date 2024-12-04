using Microsoft.AspNetCore.Mvc;
using SABank.Interfaces.Inbound;

namespace SABank.Api.Controllers
{
    [ApiController]
    [Route("/users")]
    [Produces("application/json")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
            => _userService = userService;

        [HttpGet("{idLogin}")]
        public IActionResult GetByLogin(int idLogin) 
            => Ok(_userService.GetByLogin(idLogin));
    }
}
