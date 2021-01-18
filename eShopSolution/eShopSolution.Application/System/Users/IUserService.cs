using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.System.Users;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.Application.System.Users
{
    public interface IUserService 
    {
         Task<string> Authencate(LoginRequest request);
            Task<bool> Register(RegisterRequest request);
        Task<PagedResult<UserVm>> GetUsersPaging(GetUserPagingRequest request);
    }
}