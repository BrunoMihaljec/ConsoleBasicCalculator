using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBasicCalculator
{
    class Program
    {
        static void Main()
        {
            double num1; double num2; char operation;

            Console.WriteLine("Input first number: ");
            string input1 = Console.ReadLine();
            while (!double.TryParse(input1, out num1))
            {
                Console.WriteLine("Your choice {0} is invalid please write a number.", input1);
                input1 = Console.ReadLine();
            }
            Console.WriteLine("Input second number: ");
            string input2 = Console.ReadLine();
            while (!double.TryParse(input2, out num2))
            {
                Console.WriteLine("Your choice {0} is invalid please write a number.", input2);
                input2 = Console.ReadLine();
            }
            Console.WriteLine("Input operation: \n'+' = addition,\n'-' = subtraction\n'*' or 'x' = multiplication\n'/' = division");
            string inputoperation = Console.ReadLine();
            while (!char.TryParse(inputoperation, out operation) || (operation != '+') && (operation != '-') && (operation != 'x') && (operation != '*') && (operation != '/'))
            {
                Console.WriteLine("Your choice {0} is invalid please write: \n'+' = addition,\n'-' = subtraction\n'*' or 'x' = multiplication\n'/' = division", inputoperation);
                inputoperation = Console.ReadLine();
            }
            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
