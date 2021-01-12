using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.System.Users;

namespace eShopSolution.Application.System.Users
{
    public interface IUserService
    {
         Task<string> Authencate(LoginRequest request);
            Task<bool> Register(RegisterRequest request);

    }
}