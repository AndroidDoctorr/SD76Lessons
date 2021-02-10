using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery
{
    public class Sculpture : IArt
    {
        public string ArtistName { get; }

        public string Title { get; }

        public decimal EstimatedValue { get; set; }

        public double Weight { get; set; }

        public DateTime DateCreated { get; }

        public Sculpture(string artistName, string title, DateTime dateCreated, double weight)
        {
            ArtistName = artistName;
            Title = title;
            DateCreated = dateCreated;
            Weight = weight;
        }
    }
}
