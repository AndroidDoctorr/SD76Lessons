using _07_RepositoryPattern_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _08_RepositoryPattern_Tests
{
    [TestClass]
    public class ContentTests
    {
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
    }
}
