using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class Order
    {
        public int Id { set; get; }
        public DateTime OrderDate { set; get; }
        public int UserId { set; get; }
        public string ShipName { set; get; }
        public string ShihpAddress { set; get; }
        public string ShihpEmail { set; get; }
        public string ShihpPhoneNumber { set; get; }
        public Status Status { set; get; }
    }
}
