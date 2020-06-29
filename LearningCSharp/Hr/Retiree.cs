namespace LearningCSharp.Hr
{
    public class Retiree : Person
    {
        public decimal Pension { get; private set; } = 38000;

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} is a retiree with a pension of {Pension:c}";
        }
    }
}
