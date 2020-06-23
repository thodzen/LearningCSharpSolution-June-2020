using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    // Ctrl+R, then A to run all tests

    public class TestingBasics
    {
        [Fact] // Use [Fact] to denote a test
        public void CanAddTwoNumbers()
        {
            // Given / Arrange
            int a = 10, b = 20;
            // When / Act
            int answer = a + b;
            // Then / Assert
            Assert.Equal(30, answer);
        }

        [Theory]
        [InlineData(2,2,4)] // test int a, int b, and int expected
        [InlineData(5,5,10)]
        [InlineData(20,5,25)]
        public void CanAddNumbers(int a, int b, int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }
    }
}
