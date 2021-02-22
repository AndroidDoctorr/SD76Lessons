using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_APIs.Models
{
    public class SearchResult<T>
    {
        public int Count { get; set; } = 0;
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<T> Results { get; set; } = new List<T>();
    }
}
