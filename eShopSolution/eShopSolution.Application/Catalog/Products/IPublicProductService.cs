using System;
using System.Threading.Tasks;

using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Catalog.Products;
using System.Collections.Generic;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId ,GetProductPaggingRequest request);
    
    }
}
