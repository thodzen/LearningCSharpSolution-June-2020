using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningCSharp
{
    public class MethodExamples
    {
        public string FormatName(string first, string last)
        {
            return $"{last}, {first}";
        }

        public string FormatName(string first, string last, string middle)
        {
            /*var fullname = string.Format("{0}, {1} {2}.", last, first, middle);
            return fullname;*/

            // Or

            return $"{last}, {first} {middle}.";
        }

        // if a isn't given, it will be 2
        // if b isn't given, it will be 10
        public int Add(int a=2, int b=10) 
        {
            return a + b;
        }

        // params keyword lets you pass in any number of arguments after
        // the arguments before it
        // params is always the last argument in the argument list
        public int Add(int a, int b, params int[] rest)
        {
            /*int sum = a + b;
            foreach(var num in rest)
            {
                sum += num;
            }
            return sum;*/

            // Or

            /*return a+ b+ rest.Aggregate((s, n) => s + n);*/

            // Or

            return a + b + rest.Sum();
        }
    }
}
