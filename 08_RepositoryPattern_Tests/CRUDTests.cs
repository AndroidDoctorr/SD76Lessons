using _07_RepositoryPattern_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _08_RepositoryPattern_Tests
{
    [TestClass]
    public class CRUDTests
    {
        // Fields (private variables for use within a class only)
        private StreamingContent_Repo _repo;
        private StreamingContent _content;
        private StreamingContent theRoom;

        [TestInitialize]
        public void Seed()
        {
            _repo = new StreamingContent_Repo();
            theRoom = new StreamingContent(
                "The Room",
                "Everyone betrays Johnny and he's fed up with this world",
                Maturity.R,
                5,
                GenreType.Romance
                );
            StreamingContent spaceballs = new StreamingContent(
                "Spaceballs",
                "fun in space",
                Maturity.PG,
                5,
                GenreType.Comedy
                );

            _repo.AddContentToDirectory(theRoom);
            _repo.AddContentToDirectory(spaceballs);

            _content = new StreamingContent(
                "Groundhog Day",
                "Bill Murray gets caught in a time loop for no reason",
                Maturity.PG,
                5,
                GenreType.Drama
                );
            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void AddTest()
        {
            /// AAA Testing Pattern
            /// Arrange
            /// Act
            /// Assert

            // Arrange
            StreamingContent content = new StreamingContent(
                "Galaxy Quest",
                "Sci Fi actors inadvertently go on a real Sci Fi adventure",
                Maturity.PG13,
                5,
                GenreType.Comedy
                );

            // Act
            bool wasAdded = _repo.AddContentToDirectory(content);

            Console.WriteLine(_repo.Count);

            Console.WriteLine(wasAdded);
            Console.WriteLine(content.Title);

            // Assert
            Assert.IsTrue(wasAdded);
        }


        [TestMethod]
        public void FindByTitle_ShouldGetCorrectContent()
        {
            // Arrange
            // Act
            StreamingContent searchResult = _repo.GetContentByTitle("the room");

            // Assert
            Assert.AreEqual(searchResult, theRoom);
        }
    }
}
