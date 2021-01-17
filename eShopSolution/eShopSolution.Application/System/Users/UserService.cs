using System;
using System.Text;
using System.Security.Claims;
using System.Threading.Tasks;
using eShopSolution.Data.Entities;
using eShopSolution.Utilities.Exceptions;
using eShopSolution.ViewModels.Catalog.System.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;

namespace eShopSolution.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
         private readonly  RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _config;
        public UserService(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager,
                            RoleManager<AppRole> roleManager,IConfiguration config){
              _userManager = userManager;
              _signInManager =signInManager;
              _roleManager = roleManager;
              _config =config;
        }
        public async Task<string>Authencate(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
             if(user ==null) return null;
          
           var result = await _signInManager.PasswordSignInAsync(user,request.PassWord,request.RememberMe,true);
            if (!result.Succeeded)
            {
              return null;
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims =new[]{
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.FirstName),
                new Claim(ClaimTypes.Role,string.Join(";",roles)),
                new Claim(ClaimTypes.Name,request.UserName)
              };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds =new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
           var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                       _config["Tokens:Issuer"],
                        claims,
                        expires:DateTime.Now.AddHours(3),
                        signingCredentials:creds);
       
                 return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> Register(RegisterRequest request)
        {
           var user =new AppUser(){
                 Dob =request.Dob,
                 Email =request.Email,
                 FirstName =request.FirstName,
                 LastName = request.LastName,
                 UserName = request.UserName,
                 PhoneNumber =request.PhoneNumber
           };
           var result = await _userManager.CreateAsync(user,request.PassWord);
           if(result.Succeeded)
           {
              return true;
           }
           return false;
        }

    }
}