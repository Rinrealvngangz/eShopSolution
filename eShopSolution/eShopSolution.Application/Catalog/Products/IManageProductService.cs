using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.Products.Manage;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using eShopSolution.ViewModels.Catalog.Products;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
       Task<int>  Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);

       Task<PagedResult<ProductViewModel>> GetAllPading(GetProductPaggingRequest request);

        Task<int> AddImages(string productId, List<IFormFile> files );

        Task<int> RemoveImages(string imageId);

        Task<int> UpdateImages(string imagesId, string Caption ,bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
