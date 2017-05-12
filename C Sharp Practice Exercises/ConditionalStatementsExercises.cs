using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice_Exercises
{
    class ConditionalStatementsExercises : ConsoleReadKeyClearBehavior
    {
        public static void ExecuteAllConditionalStatementsExercises()
        {
            ConditionalStatementExercise1();
        }

        private static void ConditionalStatementExercise1()
        {
            double num1 = (double)GetNumberToEqual("first", 0);
            Console.WriteLine();
            double num2 = (double)GetNumberToEqual("second", 0);
            Console.WriteLine("\n{0} and {1} are {2}", num1, num2, num1 == num2 ? "equal" : "not equal");
            ReadKeyAndClear();
        }

        private static object GetNumberToEqual(string numNumber, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nDude, you entered the wrong thing. Try it again.\n");
            Console.WriteLine("Enter the {0} number to compare...", numNumber);
            double num = 0;
            if (double.TryParse(Console.ReadLine(), out num))
                return num;
            return GetNumberToEqual(numNumber, ++attempts);
        }
    }
}
