using System;

namespace Product_cataglog.Models
{
    public class product
    {
        public int ProductId { get; set; }

        public string Image { get; set; }

        public string ProductName { get; set; }

        public string ProductCategory { get; set; }

        public decimal ProductPrice { get; set; }
    }
}