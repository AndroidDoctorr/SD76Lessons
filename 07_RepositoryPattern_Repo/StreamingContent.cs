using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repo
{
    public class StreamingContent
    {
        // private string _title;
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public Maturity MaturityRating { get; set; }

        // Make IsFamilyFriendly read-only (only a getter)
        // Based on the MaturityRating
        // (MaturityRating should probably be an enum)

        public bool IsFamilyFriendly {
            get
            {
                // This is OK
                // if (MaturityRating == Maturity.G
                //     || MaturityRating == Maturity.PG
                //     || ...)
                // {

                // }

                // This is NOT OK
                // return MaturityRating == Maturity.G ? true : MaturityRating == Maturity.PG ? true : ...
                
                switch (MaturityRating)
                {
                    case Maturity.G:
                    case Maturity.PG:
                    case Maturity.TVPG:
                    case Maturity.TVY:
                    case Maturity.TVY7:
                        return true;
                    // I don't have to specify which ones are not family friendly
                    // because "default" will catch all other cases
                    default:
                        return false;
                }
            }
        }

        public GenreType GenreType { get; set; }

        // Overloaded constructor (2 overloads)
        public StreamingContent() { }
        public StreamingContent(
            string title,
            string description,
            Maturity maturityRating,
            double stars,
            GenreType genre)
        {
            Title = title.ToUpper();
            Description = description;
            MaturityRating = maturityRating;
            StarRating = stars;
            GenreType = genre;
        }
    }

    public enum Maturity { G, PG, R, PG13, NC17, TVY, TVY7, TVMA, TVPG }
    public enum GenreType { Horror, Comedy, SciFi, Drama, Romance, Romans, Action, International, SciFiComedy }
}
