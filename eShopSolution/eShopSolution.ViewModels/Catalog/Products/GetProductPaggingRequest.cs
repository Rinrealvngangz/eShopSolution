using System;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class GetProductPaggingRequest : PagingResultRequest
    {
        public string LanguageId { get; set; }
        public int?  CategoryId { get; set; }
    }
}
