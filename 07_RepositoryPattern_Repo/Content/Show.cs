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
        public int EpisodeCount {
            get
            {
                return Episodes.Count;
            }
        }
        public double AverageRunTime { 
            get {
                double totalRunTime = 0;
                foreach (Episode ep in Episodes)
                {
                    totalRunTime += ep.RunTime;
                }
                return totalRunTime / (double)EpisodeCount;
            }
        }
        public List<Episode> Episodes { get; set; } = new List<Episode>();
    }
    public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
    }
}
