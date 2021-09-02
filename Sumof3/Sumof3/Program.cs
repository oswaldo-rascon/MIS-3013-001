using System;

namespace Sumof3
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 1;
            double secondNumber = 2;
            double thirdNumber = 3.2;

            Console.WriteLine("Please enter first number. >>");
            firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Please enter second number.>>");
             secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter third number.>>" );
             thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Answer is {0}", firstNumber + secondNumber + thirdNumber);
            Console.ReadKey();

        }
    }
}
