using System;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.Common;
using eShopSolution.ViewModels.Catalog.System.Users;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.Application.System.Users
{
    public interface IUserService 
    {
         Task<ApiResult<string>> Authencate(LoginRequest request);
          Task<ApiResult<bool>> Register(RegisterRequest request);

       Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);
        Task<ApiResult<PagedResult<UserVm>>> GetUsersPaging(GetUserPagingRequest request);

        Task<ApiResult<UserVm>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);


    }
}