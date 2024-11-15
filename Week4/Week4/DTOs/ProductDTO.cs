using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week4.DTOs
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public string Category { get; set; }
    }
}