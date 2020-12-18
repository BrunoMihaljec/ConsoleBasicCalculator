using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBasicCalculatorUpgrade
{
    class Program
    {
        static void Main()
        {
            double num1; double num2; char operation; string UserInput; string UserInput2;

            
                Console.Write("Input first number: ");
            string input1 = Console.ReadLine();
            do
            {
                while (!double.TryParse(input1, out num1))
                {
                Console.WriteLine("Your choice {0} is invalid please write a number.", input1);
                input1 = Console.ReadLine();
                }
            
                Console.WriteLine("Do you want to change entered number 'Yes' or 'No' ?");
                UserInput = Console.ReadLine().ToUpper();
                while ((UserInput != "YES") && (UserInput != "NO"))
                {
                    Console.WriteLine("{0} is not valid input please enter 'Yes' or 'No'", UserInput);
                    UserInput = Console.ReadLine().ToUpper();
                }
                if (UserInput == "YES")
                {
                    Console.WriteLine("Input first number:");
                    input1 = Console.ReadLine();
                }

            }
            while (UserInput == "YES");

            Console.Write("Input second number: ");
            string input2 = Console.ReadLine();
            do
            {
                while (!double.TryParse(input2, out num2))
                {
                Console.WriteLine("Your choice {0} is invalid please write a number.", input2);
                input2 = Console.ReadLine();
                }
            
                Console.WriteLine("Do you want to change entered number 'Yes' or 'No' ?");
                UserInput2 = Console.ReadLine().ToUpper();
                while ((UserInput2 != "YES") && (UserInput2 != "NO"))
                {
                    Console.WriteLine("{0} is not valid input please enter 'Yes' or 'No'", UserInput2);
                    UserInput2 = Console.ReadLine().ToUpper();
                }
                if (UserInput2 == "YES")
                {
                    Console.WriteLine("Input second number:");
                    input2 = Console.ReadLine();
                }

            }
            while (UserInput2 == "YES");

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
