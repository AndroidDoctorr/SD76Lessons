using _07_RepositoryPattern_Repo;
using _07_RepositoryPattern_Repo.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _08_RepositoryPattern_Tests
{
    [TestClass]
    public class ContentTests
    {
        private Show _testShow;

        [TestInitialize]
        public void Seed()
        {
            _testShow = new Show();
            _testShow.Title = "Red Dwarf";
            _testShow.Description = "A human, a cat, a robot, and a hologram stuck in deep space try to get back home";

            Episode episodeOne = new Episode();
            episodeOne.Title = "The End";
            episodeOne.RunTime = 48.0;

            Episode episodeTwo = new Episode();
            episodeTwo.Title = "Future Echoes";
            episodeTwo.RunTime = 47.0;

            Episode episodeThree = new Episode();
            episodeThree.Title = "Balance of Power";
            episodeThree.RunTime = 46.0;

            _testShow.Episodes.Add(episodeOne);
            _testShow.Episodes.Add(episodeTwo);
            _testShow.Episodes.Add(episodeThree);
        }

        [TestMethod]
        public void IsFamilyFriendlyTest()
        {
            // Arrange
            StreamingContent content = new StreamingContent();
            // Act
            content.MaturityRating = Maturity.R;
            // Assert
            Assert.IsFalse(content.IsFamilyFriendly);
        }

        [TestMethod]
        public void SetTitle_ShouldGetCorrectString()
        {
            // Arrange
            StreamingContent content = new StreamingContent();
            // Act
            content.Title = "Toy Story";
            // Assert
            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(Maturity.G, true)]
        [DataRow(Maturity.R, false)]
        [DataRow(Maturity.PG13, false)]
        [DataRow(Maturity.TVMA, false)]
        [DataRow(Maturity.TVPG, true)]
        public void SetMaturityRating_ShouldGetCorrectFamilyFriendly(Maturity rating, bool expectedFamilyFriendly)
        {
            StreamingContent content = new StreamingContent();
            content.MaturityRating = rating;

            bool actual = content.IsFamilyFriendly;
            bool expected = expectedFamilyFriendly;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void SetEpisodes_ShouldGetCount()
        {
            // Arrange
            // (see Seed())

            // Act
            // ("")

            // Assert
            // Expected THEN Actual
            Assert.AreEqual(3, _testShow.EpisodeCount);
            Assert.AreEqual(47.0, _testShow.AverageRunTime);
        }
    }
}
