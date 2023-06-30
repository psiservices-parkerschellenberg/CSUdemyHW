using CSUdemyHW.Math;

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

            int result = Calculator.Add(1, 2);
            Console.WriteLine(result);

            int[] numbers = new int[5] {1,2,3,4,5};
            Console.WriteLine(numbers[0]);

            // Check if string is a primitive type
            bool isStringPrimitive = typeof(string).IsPrimitive;
            Console.WriteLine("Is string a primitive type? " + isStringPrimitive);

            // Check if int is a primitive type
            bool isIntPrimitive = typeof(int).IsPrimitive;
            Console.WriteLine("Is int a primitive type? " + isIntPrimitive);

            // Check if StringBuilder (reference type) is a primitive type
            bool isStringBuilderPrimitive = typeof(System.Text.StringBuilder).IsPrimitive;
            Console.WriteLine("Is StringBuilder a primitive type? " + isStringBuilderPrimitive);
        }
    }
}