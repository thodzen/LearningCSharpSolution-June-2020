using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Hr
{

    public class Employee : Person
    {
        // making this "private set;" mean you can GET it no problem (public by default), 
        // but you cannot SET it to something different
        public decimal Salary { get; private set; } = 50000;

        public override string GetInfo()
        {
            if (IsHighlyCompensated())
            {
                return $"{FirstName} {LastName} is a highly paid employee with a salary of {Salary:c}";
            }
            else
            {
                return $"{FirstName} {LastName} is an employee with a salary of {Salary:c}";
            }

            // Nested method
            bool IsHighlyCompensated()
            {
                return Salary > 100000;
            }
        }


        public void GiveRaise(decimal amount)
        {
            Salary += amount;
        }
    }
}
