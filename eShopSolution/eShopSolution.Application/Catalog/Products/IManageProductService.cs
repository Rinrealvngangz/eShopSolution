using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Catalog.Products.Dtos.Manage;
using eShopSolution.Application.Dtos;
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
        

    }
}
