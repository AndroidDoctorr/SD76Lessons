using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_APIs.Models
{
    public class Person
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public string Mass { get; set; }
        public string Hair_Color { get; set; }
        public string Eye_Color { get; set; }
        public string Homeworld { get; set; }
        public List<string> Vehicles { get; set; }
        public DateTime Created { get; set; }
    }
}
