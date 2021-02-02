using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repo
{
    public class StreamingContent_Repo
    {
        // Repository Pattern: store a private list of items
        private readonly List<StreamingContent> _directory = new List<StreamingContent>();

        public int Count {
            get
            {
                return _directory.Count;
            }
        }
        // CRUD methods
        // Create
        // Read
        // Update
        // Delete

        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _directory.Count;
            // return true or false - did the add method work??
            _directory.Add(content);

            bool wasAdded = _directory.Count > startingCount;
            return wasAdded;
        }

        public List<StreamingContent> GetContents()
        {
            return _directory;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _directory)
            {
                if (title.ToLower() == content.Title.ToLower())
                {
                    return content;
                }
            }
            // Really, we would want to throw an error here and then handle it
            throw new Exception("No content with that title exists");
            // return null;
        }

        // Challenge:
        // Write a method that returns a list of only family-friendly content

    }
}
