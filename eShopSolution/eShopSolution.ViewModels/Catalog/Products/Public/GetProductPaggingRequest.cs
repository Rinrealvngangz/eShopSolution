using System;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Catalog.Products.Public
{
    public class GetProductPaggingRequest : PagingResultRequest
    {
        public int?  CategoryId { get; set; }
    }
}
