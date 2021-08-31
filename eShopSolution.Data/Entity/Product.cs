using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopSolution.Data.Entity
{

    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime CreatedDate { set; get; }
        public bool? IsFeatured { get; set; }
        
        public List<ProductInCategory> ProductInCategories { set; get; }
        public List<OrderDetail> OrderDetails { set; get; }
        public List<Cart> Carts { set; get; }
        public List<ProductTranslation> ProductTranslations { set; get; }
        public List<ProductImage> ProductImages { set; get; }
    }
}
