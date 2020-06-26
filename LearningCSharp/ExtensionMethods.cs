using LearningCSharp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class ExtensionMethods
    {
        [Fact]
        public void UsingThem()
        {
            int x = 13;
            if (x.IsEven())
            {
                // is it even
            }
            else
            {
                // it is odd
            }

            var monday = 3.DaysFromToday();

            string message = "Hello!";
            Assert.Equal(2, message.CountVowels());
        }
    }
}
