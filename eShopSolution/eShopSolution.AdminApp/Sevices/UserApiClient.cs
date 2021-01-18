using System.Threading.Tasks;
using System.Net.Http;
using eShopSolution.ViewModels.Catalog.System.Users;
using System.Text;
using System;
using Newtonsoft.Json;
using eShopSolution.ViewModels.Common;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;

namespace eShopSolution.AdminApp.Sevices
{
    public class UserApiClient :IUserApiClient
    {
        public readonly IHttpClientFactory _httpClientFactory;
        public readonly IConfiguration _configuration;

        public UserApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
                  _httpClientFactory =httpClientFactory;
                   _configuration = configuration;
        }
         public async Task<string> Authenticate(LoginRequest request)
         {
                 var json = JsonConvert.SerializeObject(request);
                 var httpContent = new StringContent(json,Encoding.UTF8,"application/json");
                     var client = _httpClientFactory.CreateClient();
                     client.BaseAddress =new Uri(_configuration["BaseAddress"]);
                  var response =  await client.PostAsync("/api/users/authenticate",httpContent);
                  var token = await response.Content.ReadAsStringAsync();
                  return token;
          }

        public async Task<PagedResult<UserVm>> GetUsersPagings(GetUserPagingRequest request)
        {
           
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            //gán vào header tên là Bearer để authorization. Vì header này mà server mới biết là user nào đang request
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", request.BearerToken);
            var response = await client.GetAsync($"/api/users/paging?Keyword={request.Keyword}"+
                                              $"&pageIndex={request.pageIndex}&pageSize={request.pageSize}");
            var body = await response.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject <PagedResult<UserVm>>(body);
            return user;
        }

        public async Task<bool> RegisterUser(RegisterRequest registerRequest)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var json = JsonConvert.SerializeObject(registerRequest);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"/api/users",httpContent);
            return response.IsSuccessStatusCode;
        }
    }
}