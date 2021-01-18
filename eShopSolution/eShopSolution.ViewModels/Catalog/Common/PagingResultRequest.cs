using eShopSolution.ViewModels.Catalog.Common;
using System;
namespace eShopSolution.ViewModels.Common
{
    public class PagingResultRequest  : RequestBase
    {
       
            public int pageIndex { get; set; }

            public int pageSize { get; set; }
        
    }
}
