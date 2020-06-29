using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class FilteringNumbers
    {
        [Fact]
        public void WeCanFilterOutEvens()
        {
            var numberFilter = new NumberFilter();
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> evens = numberFilter.FilterOutEvens(numbers);

            Assert.Equal(1, evens[0]);
            Assert.Equal(3, evens[1]);
            Assert.Equal(5, evens[2]);
            Assert.Equal(7, evens[3]);
            // etc.
        }

        [Fact]
        public void WeCanFilterOutOdds()
        {
            var numberFilter = new NumberFilter();
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> odds = numberFilter.FilterOutOdds(numbers);

            Assert.Equal(2, odds[0]);
            Assert.Equal(4, odds[1]);
            Assert.Equal(6, odds[2]);
            Assert.Equal(8, odds[3]);
            // etc.
        }

        [Fact]
        public void SelfServeFiltering()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var filter = new NumberFilter();

            var result = filter.Filter(numbers, n => n > 5);

            Assert.Equal(6, result[0]);
            Assert.Equal(7, result[1]);
            // etc.

            var evensSequence = numbers.Where(n => n % 2 == 0);

            //numbers[1] = 3;

            //var evens = evensSequence.ToList();
            //Assert.Equal(2, evens[0]);
        }

        [Theory]
        [InlineData(10,2,12)]
        [InlineData(10,15,25)]
        public void DoingMath(int a, int b, int expected)
        {
            MathOp op = (a, b) => a + b;

            var result = op(a, b);
            Assert.Equal(expected, result);
        }
    }
}
