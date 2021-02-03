using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repo.Content
{
    public class Show : StreamingContent
    {
        public int SeasonCount { get; set; }
<<<<<<< HEAD
        public int EpisodeCount {
=======

        // CHALLENGE

        // Refactor EpisodeCount and AverageRunTime to use the Episodes property
        // (no setters)

        public int EpisodeCount
        {
>>>>>>> d204ac23bc0b819c0967d6300478591d40be25a2
            get
            {
                return Episodes.Count;
            }
        }
<<<<<<< HEAD
        public double AverageRunTime { 
            get {
=======
        public double AverageRunTime
        {
            get
            {
>>>>>>> d204ac23bc0b819c0967d6300478591d40be25a2
                double totalRunTime = 0;
                foreach (Episode ep in Episodes)
                {
                    totalRunTime += ep.RunTime;
<<<<<<< HEAD
                }
                return totalRunTime / (double)EpisodeCount;
=======
                    // totalRunTime = totalRunTime + ep.RunTime;
                }
                return totalRunTime / (double) EpisodeCount;
>>>>>>> d204ac23bc0b819c0967d6300478591d40be25a2
            }
        }
        public List<Episode> Episodes { get; set; } = new List<Episode>();
    }
<<<<<<< HEAD
=======

>>>>>>> d204ac23bc0b819c0967d6300478591d40be25a2
    public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
    }
}
