using MatchingBracketsChallenge;
using Xunit;

namespace UnitTests
{
    public class UnitTests
    {
        [Theory]
        [InlineData("<>", true)]
        [InlineData("><", false)]
        [InlineData("<<>", false)]
        [InlineData("", true)]
        [InlineData("<abc...xyz>", true)]
        public void GivenUnitTests(string s, bool expectedResult)
        {
            // Arrange
            var b = new MatchingBrackets();

            // Act
            bool result = b.IsBalanced(s);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}