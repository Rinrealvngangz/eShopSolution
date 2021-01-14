using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.System.Users;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution_AdminApp.Controllers
{
    public class UserController :Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
         { 
             
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginRequest request)
        {
            return View();
        }

    }

}
