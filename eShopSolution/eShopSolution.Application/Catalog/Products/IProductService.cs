﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Catalog.ProductImages;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IProductService
    {
       Task<int>  Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);

        Task<ProductVm> GetById(int productId, string languageId);

       Task<PagedResult<ProductVm>> GetAllPading(GetManageProductPaggingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage( int imageId);

        Task<int> UpdateImage( int imagesId, ProductImageUpdateRequest request);

        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<List<ProductImageViewModel>> GetListImage(int productId);

        Task<PagedResult<ProductVm>> GetAllByCategoryId(string languageId, GetProductPaggingRequest request);



    }
}