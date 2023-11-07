using MatchingBracketsChallenge;

namespace UnitTests
{
    public class UnitTests
    {
        [Theory]
        [InlineData("<>", true)]
        [InlineData("<>", false)]
        [InlineData("<<>", false)]
        [InlineData("", true)]
        [InlineData("<abc...xyz>", true)]
        public void Test1(string s, bool expectedResult)
        {
            // Arrange
            var b = new MatchingBrackets();

            // Act
            bool result = b.HasMatchingBrackets(s);

            // Assert
            Assert.Equal(result, expectedResult);
        }
    }
}