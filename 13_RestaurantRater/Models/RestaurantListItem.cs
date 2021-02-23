using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _13_RestaurantRater.Models
{
    public class RestaurantListItem
    {
        // This is a Display Model - this is not for the database, this is for display purposes
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
    }
}