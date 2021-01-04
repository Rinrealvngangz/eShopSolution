using System;
using eShopSolution.Application.Dtos;

namespace eShopSolution.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPaggingRequest : PagingResultRequest
    {
        public int?  CategoryId { get; set; }
    }
}
