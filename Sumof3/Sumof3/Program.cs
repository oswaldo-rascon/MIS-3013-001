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
            const double seven = 7.777;


            Console.WriteLine("Please enter first number. >>");
            firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Please enter second number.>>");
             secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter third number.>>" );
             thirdNumber = double.Parse(Console.ReadLine());

            double sum = firstNumber + secondNumber + thirdNumber;

            double finalAnswer = sum * seven;
            Console.WriteLine($"The sum of these three numbers is {sum.ToString("N3")}");
            Console.WriteLine($"The sum multiplied by 7.777 is {finalAnswer.ToString("N3")}");

            
            Console.ReadKey();

        }
    }
}
