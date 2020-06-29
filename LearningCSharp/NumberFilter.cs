using LearningCSharp.Utilities;
using System;
using System.Collections.Generic;

namespace LearningCSharp
{
    // Ask c# compiler to create a class that extends System.MulticastDelegate
    // that can refer to any method that takess an in and returns a bool
    public delegate bool FilterMethod(int num);
    public delegate int MathOp(int a, int b);

    internal class NumberFilter
    {
        public List<int> FilterOutEvens(List<int> numbers)
        {
            //return Filter(numbers, IsOdd); // "Method Group" (c# 2)

            // c# 1.0 create an instance of the delegate manually
            //var op = new FilterMethod(IsOdd);
            //return FIlter(numbers, op);

            //C# 2.0 Anonymous Method
            //return Filter(numbers, delegate (int x)
            //{
            //  return x % 2 != 0;
            //});

            // c# 3.0 Lambdas
            return Filter(numbers, n =>
            {
                // do you other stuff
                return n % 2 != 0;
            });

        }


        public List<int> FilterOutOdds(List<int> numbers)
        {
            return Filter(numbers, IsEven);
        }

        public List<int> Filter(List<int> numbers, FilterMethod op)
        {
            var result = new List<int>();
            foreach (var num in numbers)
            {
                if (op(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }

        /*private bool IsOdd(int num)
        {
            return num % 2 != 0;
        }*/
        private bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}