using System;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.Common;
using eShopSolution.ViewModels.Catalog.System.Users;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.AdminApp.Sevices
{
    public interface IUserApiClient
    {
         Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<PagedResult<UserVm>>> GetUsersPagings(GetUserPagingRequest request);

        Task<ApiResult<bool>> RegisterUser( RegisterRequest registerRequest);

        Task<ApiResult<bool>> UpdateUser(Guid id , UserUpdateRequest request);

        Task<ApiResult<UserVm>> GetById(Guid id);


        Task<ApiResult<bool>> Delete(Guid id);
    }
}