using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Dtos;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
namespace eShopSolution.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly EShopDbContext _context;
        public ManageProductService(EShopDbContext context)
        {
            _context = context;
        }
      
       async Task<int> IManageProductService.Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price
            };
            _context.Products.Add(product);
          return  await _context.SaveChangesAsync();

        }

        Task<int> IManageProductService.Delete(int productId)
        {
            throw new NotImplementedException();
        }

        Task<List<ProductViewModel>> IManageProductService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<PagedViewModel<ProductViewModel>> IManageProductService.GetAllPading(string ketword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        Task<int> IManageProductService.Update(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
