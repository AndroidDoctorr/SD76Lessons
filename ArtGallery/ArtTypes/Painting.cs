using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery
{
    public class Painting : IArt
    {
        public string ArtistName { get; }

        public string Title { get; }

        public decimal EstimatedValue { get; set; }

        public double Height { get; }

        public double Width { get; }

        public DateTime DateCreated { get; }
        public Painting(string artistName, string title, DateTime dateCreated, double height, double width)
        {
            ArtistName = artistName;
            Title = title;
            DateCreated = dateCreated;
            Height = height;
            Width = width;
        }
    }
}
