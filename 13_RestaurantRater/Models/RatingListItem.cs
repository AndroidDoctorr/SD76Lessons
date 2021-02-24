using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _13_RestaurantRater.Models
{
    public class RatingListItem
    {
        public int Id { get; set; }
        // public double AverageScore { get; set; }
        public double FoodScore { get; set; }
        public string RestaurantName { get; set; }
    }
}