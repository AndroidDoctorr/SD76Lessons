using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.ArtTypes
{
    public class Relief : Sculpture
    {
        public double Height { get; }
        public double Width { get; }

        public Relief(double height, double width, string title, string artistName, DateTime dateCreated, double weight) : base(artistName, title, dateCreated, weight)
        {
            Height = height;
            Width = width;
        }
    }
}
