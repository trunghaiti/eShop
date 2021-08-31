using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class Cart
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public DateTime CreatedDate { get; set; }

        public Guid UserId { set; get; }

        public AppUser AppUser { set; get; }
        public Product Product { set; get; }
    }
}
