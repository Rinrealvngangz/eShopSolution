using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.System.Users;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.AdminApp.Sevices
{
    public interface IUserApiClient
    {
         Task<string> Authenticate(LoginRequest request);

        Task<PagedResult<UserVm>> GetUsersPagings(GetUserPagingRequest request);

        Task<bool> RegisterUser( RegisterRequest registerRequest);
    }
}