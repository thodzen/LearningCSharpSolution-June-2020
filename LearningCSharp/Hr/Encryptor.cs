namespace LearningCSharp.Hr
{
    // sealed cannot be inheritied from
    public sealed class Encryptor
    {
        public bool IsGoodPassword(string password)
        {
            return password == "super_secret"; // put your super encrypted code here
        }
    }
}
