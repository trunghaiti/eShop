using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class Promotion
    {
        public int Id { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public Status ApplyForAll { set; get; }
        public decimal DiscountPercent { set; get; }
        public decimal DiscountAmong { set; get; }
        public int ProductId { set; get; }
        public int ProductCategoryId { set; get; }
        public Status Status { set; get; }
        public string Name { set; get; }


    }
}
