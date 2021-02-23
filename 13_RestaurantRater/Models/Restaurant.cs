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
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string Owner { get; set; }

        public virtual List<Rating> Ratings { get; set; }
        public double Rating
        {
            get
            {
                double totalAverageRating = 0;
                foreach (var rating in Ratings)
                {
                    totalAverageRating += rating.AverageScore;
                }
                return (Ratings.Count > 0)
                    ?
                        totalAverageRating / Ratings.Count
                    :
                        0;
            }
        }

        public double AverageFoodScore
        {
            get
            {
                // Select LINQ Method - convert a list to another type of list
                IEnumerable<double> scores = Ratings.Select(r => r.FoodScore);
                double totalFoodScores = scores.Sum();

                return Ratings.Count > 0 ? totalFoodScores / Ratings.Count : 0;
            }
        }
    }
}