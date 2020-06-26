using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class Helpers
    {
        // Generic method
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
