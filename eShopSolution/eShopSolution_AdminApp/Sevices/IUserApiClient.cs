using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.System.Users;
namespace eShopSolution_AdminApp.Sevices
{
    public interface IUserApiClient
    {
         Task<string> Authenticate(LoginRequest request);
    }
}