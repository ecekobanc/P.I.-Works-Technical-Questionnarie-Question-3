using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 15;
            //Before swap
            Console.WriteLine("Value of first number: " + number1);
            Console.WriteLine("Value of second number: " + number2);

            number1 = number1 * number2;
            number2 = number1 / number2;
            number1 = number1 / number2;
            //After swap
            Console.WriteLine("Value of first number: " + number1);
            Console.WriteLine("Value of second number: " + number2);

            Console.ReadLine();
        }
    }
}
