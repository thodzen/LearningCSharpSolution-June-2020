using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    // abstract = "only there to be inherited from"
    public abstract class Person
    {
        // C#'s way of doing getters and setters

        // "Backing Field"
        private string _firstName;

        // Writing it out
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        // Shortcut that does the rest within the compiler
        public string LastName { get; set; }

        // abstract methods must be implemented on the class that inherits it
        public abstract string GetInfo();
    }

    public class Employee : Person
    {
        // making this "private set;" mean you can GET it no problem (public by default), 
        // but you cannot SET it to something different
        public decimal Salary { get; private set; } = 50000;

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} is an employee with a salary of {Salary:c}";
        }

        public void GiveRaise(decimal amount)
        {
            Salary += amount;
        }
    }

    public class Retiree : Person
    {
        public decimal Pension { get; private set; } = 38000;

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} is a retiree with a pension of {Pension:c}";
        }
    }

    // sealed cannot be inheritied from
    public sealed class Encryptor
    {
        public bool IsGoodPassword(string password)
        {
            return password == "super_secret"; // put your super encrypted code here
        }
    }
}
