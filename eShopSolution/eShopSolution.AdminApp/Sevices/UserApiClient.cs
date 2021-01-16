using System.Threading.Tasks;
using System.Net.Http;
using eShopSolution.ViewModels.Catalog.System.Users;
using System.Text;
using System;
using Newtonsoft.Json;
namespace eShopSolution.AdminApp.Sevices
{
    public class UserApiClient :IUserApiClient
    {
        public readonly IHttpClientFactory _httpClientFactory;

        public UserApiClient(IHttpClientFactory httpClientFactory)
        {
                  _httpClientFactory =httpClientFactory;
        }
         public async Task<string> Authenticate(LoginRequest request)
         {
                 var json = JsonConvert.SerializeObject(request);
                 var httpContent = new StringContent(json,Encoding.UTF8,"application/json");
                     var client = _httpClientFactory.CreateClient();
                     client.BaseAddress =new Uri("https://localhost:5001");
                  var response =  await client.PostAsync("/api/users/authenticate",httpContent);
                  var token = await response.Content.ReadAsStringAsync();
                  return token;
          }
    }
}