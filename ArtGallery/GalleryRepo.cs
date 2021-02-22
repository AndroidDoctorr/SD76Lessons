using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery
{
    public class GalleryRepo
    {
        private readonly List<IArt> _gallery = new List<IArt>();
        
        public int Total
        {
            get
            {
                return _gallery.Count;
            }
        }

        //Create 
        public bool AddArt(IArt art)
        {
            int startingCount = _gallery.Count;

            _gallery.Add(art);
            
            bool wasAdded = _gallery.Count > startingCount;
            return wasAdded;
        }
        //Read
        public List<IArt> GetArt()
        {
            return _gallery;
        }
    }
}
