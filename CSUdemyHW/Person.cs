namespace CSUdemyHW
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void SayHi()
        {
            Console.WriteLine("Hi, I'm " + FirstName + " " + LastName);
        }
    }
}