using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.System.Users
{
    public class GetUserPagingRequest : PagingResultRequest
    {
        public  string Keyword { get; set; }
    }
}
