using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class MethodsTests
    {
        // Overloading
        [Fact]
        public void OverloadingMethods()
        {
            // Definpition - many methods with the same name
            // that vary by type and/or number of arguments

            var methods = new MethodExamples();

            var fullName = methods.FormatName("Han", "Solo");

            Assert.Equal("Solo, Han", fullName);

            fullName = methods.FormatName("Han", "Solo", "D");

            Assert.Equal("Solo, Han D.", fullName);
        }


        // Defaults
        [Fact]
        public void Defaults()
        {
            var methods = new MethodExamples();

            Assert.Equal(4, methods.Add(2, 2));
            Assert.Equal(20, methods.Add(10));
            Assert.Equal(12, methods.Add());
        }


        // Params
        [Fact]
        public void UsingTheParams()
        {
            var methods = new MethodExamples();

            // 1, 2 are a, b
            // 3,4,5,6,7,8,9 are in the int[] rest
            var total = methods.Add(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Assert.Equal(45, total);
        }
    }
}
