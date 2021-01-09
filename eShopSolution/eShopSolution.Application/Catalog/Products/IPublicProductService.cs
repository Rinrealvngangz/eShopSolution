using System;
using System.Threading.Tasks;

using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Catalog.Products;
using System.Collections.Generic;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPaggingRequest request);
        Task<List<ProductViewModel>> GetAll(string  languageId);
    }
}
