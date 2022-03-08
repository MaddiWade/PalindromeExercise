using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        public void IsAPalindrome(string word, bool expected)
        {
            // Arrange
            var ws = new Wordsmith();

            // Act
            var actual = ws.IsAPalindrome(word);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
