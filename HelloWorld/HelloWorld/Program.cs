using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        static bool MainMenu()
        {
 //MENY
            Console.Clear();
            Console.WriteLine("------------Calculator------------");
            Console.WriteLine("Enter the selection you want to do");
            Console.WriteLine();
            Console.WriteLine("Press 1 for Addison");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine();
            Console.WriteLine("Press 9 for exit the calculater");
            Console.Write("\r\nSelect an option: ");


 // keypress
            switch (Console.ReadLine())
            {
                case "1":
                    addisionString();
                    return true;
                case "2":
                    substractionString();
                    return true;
                case "3":
                    muliplicationString();
                    return true;
                case "4":                    
                    divisionString();
                    return true;
                case "9":
                    return false;
                default:
                    return true;
            }
        }

 // Mattematik functionerna
        static string addisionString()
 //int.Parse //  Unhandled exception. System.ArgumentNullException: Value cannot be null.
 //eller
 //Convert.ToInt32 // Converting String is a numeric representation: 0 <<< valde denna
        {
            Console.Clear();
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32((Console.ReadLine()));

            int result = number1 + number2;
            Console.WriteLine(result);
            return Console.ReadLine();
        }

        static string substractionString()
        {
            Console.Clear();
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32((Console.ReadLine()));

            int result = number1 - number2;
            Console.WriteLine(result);
            return Console.ReadLine();
        }

        static string muliplicationString()
        {
            Console.Clear();
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32((Console.ReadLine()));

            int result = number1 * number2;
            Console.WriteLine(result);
            return Console.ReadLine();
        }

 // frågade chatgpt om varför static string divisionString() blev fel som ledde till static void.
        static void divisionString()
        {
            Console.Clear();
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32((Console.ReadLine()));

            if (number2 == 0)
            {
                Console.Write("can't divide by zero");
            }
            else
            {
                int result = number1 / number2;
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
