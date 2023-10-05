using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("wow", true)]
        [InlineData("TrueCoders", false)]
        [InlineData("Palindrome", false)]
        public void MyTest(string word, bool expected)
        {
            var test = new WordSmith();

            bool actual = test.isAPalinDrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
