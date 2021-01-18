using System.Threading.Tasks;
using System.Net.Http;
using eShopSolution.ViewModels.Catalog.System.Users;
using System.Text;
using System;
using Newtonsoft.Json;
using eShopSolution.ViewModels.Common;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using eShopSolution.ViewModels.Catalog.Common;
using Microsoft.AspNetCore.Http;

namespace eShopSolution.AdminApp.Sevices
{
    public class UserApiClient :IUserApiClient
    {
        public readonly IHttpClientFactory _httpClientFactory;
        public readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
                  _httpClientFactory =httpClientFactory;
                   _configuration = configuration;
                  _httpContextAccessor = httpContextAccessor;
        }
         public async Task<ApiResult<string>> Authenticate(LoginRequest request)
         {
                 var json = JsonConvert.SerializeObject(request);
                 var httpContent = new StringContent(json,Encoding.UTF8,"application/json");
                     var client = _httpClientFactory.CreateClient();
                     client.BaseAddress =new Uri(_configuration["BaseAddress"]);
                  var response =  await client.PostAsync("/api/users/authenticate",httpContent);
                var token = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
               
                return JsonConvert.DeserializeObject<ApiResult<string>>(token);    
            }

            return JsonConvert.DeserializeObject<ApiErrorResult<string>>(token);
        }

        public async Task<ApiResult<UserVm>> GetById(Guid id)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.GetAsync($"/api/users/{id}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {

                return JsonConvert.DeserializeObject<ApiSuccessResult<UserVm>>(body);
            }

            return JsonConvert.DeserializeObject<ApiErrorResult<UserVm>>(body);
        }

        public async Task<ApiResult<PagedResult<UserVm>>> GetUsersPagings(GetUserPagingRequest request)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            //gán vào header tên là Bearer để authorization. Vì header này mà server mới biết là user nào đang request
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.GetAsync($"/api/users/paging?Keyword={request.Keyword}"+
                                              $"&pageIndex={request.pageIndex}&pageSize={request.pageSize}");
            var body = await response.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject <ApiSuccessResult<PagedResult<UserVm>>>(body);
            return user;
        }

        public async Task<ApiResult<bool>> RegisterUser(RegisterRequest registerRequest)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var json = JsonConvert.SerializeObject(registerRequest);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"/api/users",httpContent);
             var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);
            }
            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }

        public async Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request)
        {

            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
        

            var response = await client.PutAsync($"/api/users/{id}", httpContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);
            }
            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }

   
    }
}