using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _13_RestaurantRater.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(0, 10)]
        public double FoodScore { get; set; }

        [Required]
        [Range(0, 10)]
        public double EnvironmentScore { get; set; }

        [Required]
        [Range(0, 10)]
        public double CleanlinessScore { get; set; }

        public double AverageScore
        {
            get
            {
                return (FoodScore * 2 + CleanlinessScore + EnvironmentScore) / 4;
            }
        }

        // Entity Framework recognizes "Restaurant" and "Id" - it can guess what this is
        [Required]
        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }
        // This is a virtual property - it does not get stored in the DB, it just shows up when we get this item
        public virtual Restaurant Restaurant { get; set; }
    }
}