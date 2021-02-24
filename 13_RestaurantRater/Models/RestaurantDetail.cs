using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _13_RestaurantRater.Models
{
    public class RestaurantDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        public string Owner { get; set; }
        public double AverageFoodScore { get; set; }
    }
}