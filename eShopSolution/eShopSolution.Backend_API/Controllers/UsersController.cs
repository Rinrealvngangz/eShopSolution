using System;
using eShopSolution.Application.System.Users;
using eShopSolution.ViewModels.Catalog.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
namespace eShopSolution.Backend_API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class UsersController :Controller
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService){
             _userService =userService;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]

        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request){
                  if(!ModelState.IsValid){
                      return BadRequest(ModelState);
                  }
                  var resultToken = await _userService.Authencate(request);
                  if(String.IsNullOrEmpty(resultToken)){
                      return BadRequest("Username or password is incorrect.");
                  }
                  return Ok(resultToken);
        }
         [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> Register([FromBody] RegisterRequest request){
                  if(!ModelState.IsValid){
                      return BadRequest(ModelState);
                  }
                  var result = await _userService.Register(request);
                  if(!result){
                      return BadRequest("Register is unsuccessful!");
                  }
                  return Ok("Successed!");
        }
        //https://localhost/api/users/paging?pageSize=10&pageIndex=2$keyword=
        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetUserPagingRequest request)
        {

            var product = await _userService.GetUsersPaging(request);
            return Ok(product);

        }

    }
}