using System.Collections.Generic;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class GetManageProductPaggingRequest : PagingResultRequest 
    {
        public string KeyWord { get; set; }
        public List<int> Categories { get; set; }
    }
}
