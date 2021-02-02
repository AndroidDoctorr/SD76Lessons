using _07_RepositoryPattern_Repo;
using _07_RepositoryPattern_Repo.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
                // new List<GenreType> { GenreType.Comedy, GenreType.SciFi }
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



            Show show = new Show();
            show.Title = "Arrested Development";
            show.SeasonCount = 4; // Yes that is correct don't look it up Season 5 does not exist.
            Episode ep = new Episode();
            ep.Title = "Courting Disasters";
            Episode ep2 = new Episode();
            ep2.Title = "Pier Pressure";

            _repo.AddContentToDirectory(show);

            Movie movie = new Movie();
            movie.Title = "Roller Blade";
            movie.Description = "In a world of blood and greed, curvaceous crusaders battle to rebuild a battered land.";

            _repo.AddContentToDirectory(movie);
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

        [TestMethod]
        public void GetFamilyFriendly_ShouldOnlyGetFamilyFriendly()
        {
            // Arrange
            // Act
            List<StreamingContent> familyFriendly = _repo.GetFamilyFriendlyContent();
            // Assert
            foreach (StreamingContent content in familyFriendly)
            {
                Assert.IsTrue(content.IsFamilyFriendly);
            }
            Assert.AreEqual(2, familyFriendly.Count);
        }

        [TestMethod]
        public void UpdateContent_ShouldUpdate()
        {
            StreamingContent newContent = new StreamingContent(
                "Spaceballs",
                "A star pilot and his sidekick must come to the rescue of a Princess and save the galaxy from a ruthless race of beings known as Spaceballs.",
                Maturity.PG13,
                5,
                GenreType.SciFiComedy
                );

            bool wasUpdated = _repo.UpdateExistingContent("Spaceballs", newContent);

            Assert.IsTrue(wasUpdated);

            StreamingContent updatedContent = _repo.GetContentByTitle("Spaceballs");

            GenreType expected = GenreType.SciFiComedy;
            GenreType actual = updatedContent.GenreType;

            Assert.AreEqual(expected, actual);
            Console.WriteLine(updatedContent.Description);
        }

        [TestMethod]
        public void DeleteContent_ShouldDelete()
        {
            bool wasRemoved = _repo.DeleteContent("the room");
            Assert.IsTrue(wasRemoved);

            bool wasAlsoRemoved = _repo.DeleteContent("fkjhgjhkgkjh");
            Assert.IsFalse(wasAlsoRemoved);
        }
    }
}
