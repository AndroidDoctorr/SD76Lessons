using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery
{
    public interface IArt
    {
        string ArtistName { get; }
        string Title { get; }
        decimal EstimatedValue { get; set; }
        DateTime DateCreated { get; }
    }

}
