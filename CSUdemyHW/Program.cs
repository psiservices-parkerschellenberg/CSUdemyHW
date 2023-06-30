namespace CSUdemyHW
{

    internal class Program // PROGRAM CLASS
    {
        static void Main(string[] args) // MAIN METHOD (ENTRY POINT OF APP)
        {
            Person parker = new Person();
            parker.FirstName = "Parker";
            parker.LastName = "Schell";
            parker.SayHi();
        }
    }
}