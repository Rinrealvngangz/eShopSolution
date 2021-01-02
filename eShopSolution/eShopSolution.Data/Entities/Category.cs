using System;
using eShopSolution.Data.Enums;
namespace eShopSolution.Data.Entities
{
    public class Category
    {
        
        public int Id { get; set; }
        public decimal SortOrder { get; set; }
        public int IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status  { get; set; }

      
   
    }
}
