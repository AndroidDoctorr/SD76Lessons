using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _13_RestaurantRater.Models
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("DefaultConnection") { }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}