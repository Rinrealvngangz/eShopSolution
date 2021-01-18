using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.System.Users;
using Microsoft.AspNetCore.Mvc;
using eShopSolution.AdminApp.Sevices;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Microsoft.IdentityModel.Logging;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication;
using System;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace eShopSolution.AdminApp.Controllers
{
    public class UserController :BaseController
    {
        private readonly IUserApiClient _userApiClient;
       
        private readonly IConfiguration _configuration;

        public UserController(IUserApiClient userApiClient, IConfiguration configuration)
        {
                    _configuration = configuration;
                   _userApiClient = userApiClient;
        }
        public async Task<IActionResult> Index(string keyword ,int pageIndex =1 ,int pageSize =10)
        {
        
            var request = new GetUserPagingRequest()
            {
             
                Keyword =keyword,
                pageIndex =pageIndex,
                pageSize =pageSize
            };
            var data =  await _userApiClient.GetUsersPagings(request);
            return View(data.ResultObj);
        }
       

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
             HttpContext.Session.Remove("Token");
            return RedirectToAction("Login", "User");
        }

        [HttpGet]
        public IActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterRequest registerRequest)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _userApiClient.RegisterUser(registerRequest);
            if (result.IsSuccessed)
             return RedirectToAction("Index");
            ModelState.AddModelError("", result.Message);
            return View(registerRequest);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _userApiClient.UpdateUser(request.Id ,request);
            if (result.IsSuccessed)
                return RedirectToAction("Index");
            ModelState.AddModelError("", result.Message);
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var result = await _userApiClient.GetById(id);
            if (result.IsSuccessed)
            {
                var user = result.ResultObj;
                var updateRequest = new UserUpdateRequest()
                {
                    Dob = user.Dob,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    Id = id
                };
                return View(updateRequest);
            }
            return RedirectToAction("Error", "Home");
        }


    }

}
