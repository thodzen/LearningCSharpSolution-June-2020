namespace LearningCSharp.Hr
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
}
