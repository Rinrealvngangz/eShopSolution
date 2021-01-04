using System;
using System.Collections.Generic;
using eShopSolution.Application.Dtos;
namespace eShopSolution.Application.Catalog.Products.Dtos.Manage
{
    public class GetProductPaggingRequest : PagingResultRequest 
    {
        public string KeyWord { get; set; }
        public List<int> Categories { get; set; }
    }
}
