using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _14_GeneralStore.Models
{
    public class ProductUpdate
    {
        public string ProductName { get; set; }
        public string UPC { get; set; }
        [Range(0, 10000)]
        public decimal Price { get; set; }
    }
}