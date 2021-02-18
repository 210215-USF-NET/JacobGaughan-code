using System;
using Xunit;
using ToHModels;
// Note that models aren't really supposed to be unit tested because they mainly hold data
// focus on unit testing logic (business logic & data layer logic)
// Also don't test UI
namespace ToHTests
{
    public class HeroModelTest
    {
        // 3 parts of a unit test: arrange, act, & assert
        // Arrange - setting up the things you need for the unit test
        // Act - doing the thing you wanna test
        // Assert - comparing the actual results to the expected outcome

        // Arrange
        private Hero testHero = new Hero();

        [Fact]
        public void HeroNameShouldBeSet()
        {
            string testName = "The tick";
            // Act
            testHero.HeroName = testName;
            // Assert
            Assert.Equal(testName, testHero.HeroName);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void HeroNameShouldNotBeEmpty(string testName)
        {
            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => testHero.HeroName = testName);
        }
    }
}
