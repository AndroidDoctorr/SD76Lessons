using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repo.Content
{
    public class Movie : StreamingContent
    {
        public double RunTime { get; set; }

        public Movie() {}

        public Movie(
            string title,
            string description,
            Maturity rating,
            GenreType genre,
            double stars,
            double runTime)
            : base(title, description, rating, stars, genre)
        {
            RunTime = runTime;
        }
    }
}
