using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Sevices
{
  
        public class ProductApiClient : BaseApiClient, IProductApiClient
        {
            public ProductApiClient(IHttpClientFactory httpClientFactory,
                       IHttpContextAccessor httpContextAccessor,
                        IConfiguration configuration)
                : base(httpClientFactory, httpContextAccessor, configuration)
            {
            }

            public async Task<PagedResult<ProductVm>> GetPagings(GetManageProductPaggingRequest request)
            {
                var data = await GetAsync<PagedResult<ProductVm>>(
                    $"/api/products/paging?pageIndex={request.pageIndex}" +
                    $"&pageSize={request.pageSize}" +
                    $"&keyword={request.KeyWord}&languageId={request.LanguageId}");

                return data;
            }


        }
    
}
