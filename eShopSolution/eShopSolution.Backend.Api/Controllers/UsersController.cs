using System;
using eShopSolution.Application.System.Users;
using eShopSolution.ViewModels.Catalog.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
namespace eShopSolution.Backend.Api.Controllers
{
    [Route("api/[controller]")]
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
                  return Ok(new {token =resultToken});
        }
         [HttpPost("register")]
        [AllowAnonymous]

        public async Task<IActionResult> Register([FromForm] RegisterRequest request){
                  if(!ModelState.IsValid){
                      return BadRequest(ModelState);
                  }
                  var result = await _userService.Register(request);
                  if(!result){
                      return BadRequest("Register is unsuccessful!");
                  }
                  return Ok("Successed!");
        }


    }
}