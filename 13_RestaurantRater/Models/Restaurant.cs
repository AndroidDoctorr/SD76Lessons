using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _13_RestaurantRater.Models
{
    public class Restaurant
    {
        // Database model - serializable (POCO)
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Range(0.0, 5.0)]
        public double Rating { get; set; }
    }
}