using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class VariablesAndDataTypes
    {

        [Fact]
        public void SomeOfTheBuiltInTypes() 
        {
            // Type Identifier;
            int age;
            age = 22;
            Int32 yourAge;
            yourAge = 23;

            string name;
            name = "Tyler";
            String yourName;
            yourName = "Tyler2";

            // Initializing - assigning a value when declaring
            Double pay = 33.22;
            decimal yourPay = 33.22M;

            Boolean isAwake = true;
            bool over = 12 > 13;

            int x;

            x = 0;
            Assert.Equal(0, x);
        }

        [Fact]
        public void ImplicitlyTypedLocalVariable()
        {
            // You can use var, but you HAVE to initalize it
            // Can only use var with local variables
            var pay = 32.50M; // It knows this is a decimal
            // C# is a strictly typed language.
            // A variable can never change its data type
            // Born an integer? You will ALWAYS be an integer
        }

        [Fact]
        public void ValueTypes()
        {
            // Structs create Stack Value Types
            // Classes create Heap Reference Types
            // Reference types are REFERENCED in the heap
            // Object live on the heap

            //Structs
            int age = 52;
            DateTime myBirthday = new DateTime(1969, 4, 20);
            string myName = "Jeff";

            DoubleIt(age);
            Assert.Equal(52, age);

            var rover = new Dog();
            rover.Name = "Rover";
            DoSomething(rover);
            Assert.Equal("Fido", rover.Name);
        }

        [Fact]
        public void UsingRefAndOut()
        {
            // comment: ctrl + k, ctrl + c
            // uncomment: ctrl + k, ctrl + u
            int y = 50;
            DoubleItRef(ref y);
            Assert.Equal(100, y);

            //int p;
            //GimmeSomething(out p);
            GimmeSomething(out int p);
            Assert.Equal(42, p);
        }

        public void DoubleItRef(ref int x)
        {
            x = x + x;
        }

        public void GimmeSomething(out int z) 
        {
            z = 42;
        }

        public void DoubleIt(int age)
        {
            age = age + age;
        }

        public void DoSomething(Dog d)
        {
            d.Name = "Fido";
        }

    }

    public class Dog {
        public string Name;
    }
}
