using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.Dtos
{
    public class ProductViewModel
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime CreatedDate { set; get; }
        public bool? IsFeatured { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Detail { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { set; get; }
        public string LanguageId { set; get; }
    }
}
