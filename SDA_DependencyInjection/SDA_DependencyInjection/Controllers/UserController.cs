using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SDA_DependencyInjection.BusinessLayer.Interfaces;

namespace SDA_DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService) 
        {
            _userService= userService;
        }

        [HttpGet(Name = "merrfitimetperuser")]
        public double MerrFitimetPerUser(int userID)
        {
            var fitimet = _userService.MerrFitimetPerUser(userID);
            return fitimet;
        }

    }
}
