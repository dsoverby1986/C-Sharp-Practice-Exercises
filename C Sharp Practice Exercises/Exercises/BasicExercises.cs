using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Practice_Exercises.Extensions;

namespace C_Sharp_Practice_Exercises.Exercises
{
    class BasicExercises : ConsoleReadKeyClearBehavior
    {
        public static void ShowBasicExerciseMenu()
        {
            Console.WriteLine("***BASIC EXERCISES***\n\nChoose an option from the menu below:\n");
            foreach (KeyValuePair<int, string> option in BasicExerciseMenuOptions)
                Console.WriteLine($"{(option.Key < 10 ? " " : "")}{option.Key}.) {option.Value}");
            Console.WriteLine();
            NavigateUsersRequest();
        }

        private static readonly Dictionary<int, string> BasicExerciseMenuOptions = new Dictionary<int, string>()
        {
            { 1, "Execute Exercise 1  - Hello Shane" },
            { 2, "Execute Exercise 2  - Addition" },
            { 3, "Execute Exercise 3  - Division" },
            { 4, "Execute Exercise 4  - Mathematical Operations" },
            { 5, "Execute Exercise 5  - Number Swap" },
            { 6, "Execute Exercise 6  - Tri-Number Multiplication" },
            { 7, "Execute Exercise 7  - Add/Subtract/Multiply/Divide/Mod" },
            { 8, "Execute Exercise 8  - Multiplication Table" },
            { 9, "Execute Exercise 9  - Calculate Average" },
            { 10, "Execute Exercise 10 - Two Random Operations" },
            { 11, "Execute Exercise 11 - Age Insult" },
            { 12, "Execute Exercise 12 - Number Pattern" },
            { 13, "Execute Exercise 13 - Number Rectangle" },
            { 14, "Execute Exercise 14 - Temperature Conversion" },
            { 15, "Execute All Basic Exercises" },
            { 16, "Go Back to Main Menu" }
        };

        private static void NavigateUsersRequest()
        {
            int request = (int)GetUsersRequest(0);
            Console.Clear();
            switch (request)
            {
                case 1:
                    BasicExercise1();
                    break;
                case 2:
                    BasicExercise2();
                    break;
                case 3:
                    BasicExercise3();
                    break;
                case 4:
                    BasicExercise4();
                    break;
                case 5:
                    BasicExercise5();
                    break;
                case 6:
                    BasicExercise6();
                    break;
                case 7:
                    BasicExercise7();
                    break;
                case 8:
                    BasicExercise8();
                    break;
                case 9:
                    BasicExercise9();
                    break;
                case 10:
                    BasicExercise10();
                    break;
                case 11:
                    BasicExercise11();
                    break;
                case 12:
                    BasicExercise12();
                    break;
                case 13:
                    BasicExercise13();
                    break;
                case 14:
                    BasicExercise14();
                    break;
                case 15:
                    ExecuteAllBasicExercises();
                    break;
                case 16:
                    Program.Main(new string[] { });
                    break;
                default:
                    Console.Clear();
                    ReadKeyAndClear();
                    ShowBasicExerciseMenu();
                    break;
            }
            if (Program.ReturnToMainMenu)
                Program.Main(new string[] { });
            else
                ShowBasicExerciseMenu();
        }

        private static object GetUsersRequest(int attempts)
        {
            if (attempts > 0)
            {
                Console.WriteLine("\nYour input is invalid. Try again.\n");
                ReadKeyAndClear();
                ShowBasicExerciseMenu();
            }
            int request = 0;
            if (Int32.TryParse(Console.ReadLine(), out request) && BasicExerciseMenuOptions.Keys.Contains(request))
                return request;
            return GetUsersRequest(++attempts);
        }

        public static void ExecuteAllBasicExercises()
        {
            BasicExercise1();
            BasicExercise2();
            BasicExercise3();
            BasicExercise4();
            BasicExercise5();
            BasicExercise6();
            BasicExercise7();
            BasicExercise8();
            BasicExercise9();
            BasicExercise10();
            BasicExercise11();
            BasicExercise12();
            BasicExercise13();
            BasicExercise14();
        }

        private static void BasicExercise1()
        {
            Console.WriteLine("Hello: Shane Overby");
            ReadKeyAndClear();
        }

        private static void BasicExercise2()
        {
            Console.WriteLine("12 + 33 = {0}", (12 + 33));
            ReadKeyAndClear();
        }

        private static void BasicExercise3()
        {
            Console.WriteLine("276 / 14 = {0}", (276 / 14));
            ReadKeyAndClear();
        }

        private static void BasicExercise4()
        {
            Console.WriteLine("-1 + 4 * 6 = {0}", (-1 + 4 * 6));
            Console.WriteLine("(35 + 5) % 7 = {0}", ((35 + 5) % 7));
            Console.WriteLine("14 + -4 * 6 / 11 = {0}", (14 + -4 * 6 / 11));
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = {0}", (2 + 15 / 6 * 1 - 7 % 2));
            ReadKeyAndClear();
        }

        private static void BasicExercise5()
        {
            double firstNumber = (double)GetNumberForSwap("first", 0);
            double secondNumber = (double)GetNumberForSwap("second", 0);
            Console.WriteLine("First Number: {0}", secondNumber);
            Console.WriteLine("Second Number: {0}", firstNumber);
            ReadKeyAndClear();
        }

        private static object GetNumberForSwap(string numNumber, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("Dude, just give me a number, like I said. Come On!");
            Console.WriteLine("Input the {0} number...", numNumber);
            double num = 0;
            if (double.TryParse(Console.ReadLine(), out num))
                return num;
            else
                return GetNumberForSwap(numNumber, ++attempts);
        }

        private static void BasicExercise6()
        {
            Dictionary<int, int?> factors = new Dictionary<int, int?>()
            {
                { 1, null },
                { 2, null },
                { 3, null }
            };
            string[] numFactors = { "first", "second", "third" };
            for(int i = 0; i < numFactors.Length; i++)
                factors[i + 1] = (int?)GetFactor(numFactors[i], 0);
            int product = 1;
            for (int i = 1; i <= factors.Count; i++)
                product *= factors[i].Value;
            Console.WriteLine("{0} * {1} * {2} = {3}", factors[1], factors[2], factors[3], product);
            ReadKeyAndClear();
        }

        private static object GetFactor(string numFactor, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("You douche nugget! I said a POSITIVE INTEGER! Get it right next time ass wipe!");
            Console.WriteLine("Input the {0} positive integer to multiply...", numFactor);
            int factor = 0;
            if (Int32.TryParse(Console.ReadLine(), out factor) && factor > 0)
                return factor;
            else
                return GetFactor(numFactor, ++attempts);
        }

        private static void BasicExercise7()
        {
            double numOne = (double)GetAddSubtractMultiplyDivideModNumber("first", 0);
            double numTwo = (double)GetAddSubtractMultiplyDivideModNumber("second", 0);
            Console.WriteLine("{0} + {1} = {2}", numOne, numTwo, numOne + numTwo);
            Console.WriteLine("{0} - {1} = {2}", numOne, numTwo, numOne - numTwo);
            Console.WriteLine("{0} * {1} = {2}", numOne, numTwo, numOne * numTwo);
            Console.WriteLine("{0} / {1} = {2}", numOne, numTwo, numOne / numTwo);
            Console.WriteLine("{0} mod {1} = {2}", numOne, numTwo, numOne % numTwo);
            ReadKeyAndClear();
        }

        private static object GetAddSubtractMultiplyDivideModNumber(string numNumber, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("Hey Buddy, I said you need to give me a NUMBER, OTHER THAN ZERO. So do it!");
            Console.WriteLine("Enter the {0} number, other than 0, to add, subtract, multiply and divide...", numNumber);
            double num = 0;
            if (double.TryParse(Console.ReadLine(), out num) && num != 0)
                return num;
            else
                return GetAddSubtractMultiplyDivideModNumber(numNumber, ++attempts);
        }

        private static void BasicExercise8()
        {
            double multNum = (double)GetMultiplier(0);
            for (var i = 0; i <= 10; i++)
                Console.WriteLine("{0} * {1} = {2}", multNum, i, multNum * i);
            ReadKeyAndClear();
        }

        private static object GetMultiplier(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("Listen, pal. I said enter a NUMBER. Let's try that again.");
            Console.WriteLine("Enter a number to get it's multiplication table...");
            double multiplier = 0;
            if (double.TryParse(Console.ReadLine(), out multiplier))
                return multiplier;
            else
                return GetMultiplier(++attempts);
        }

        private static void BasicExercise9()
        {
            double avOne = (double)GetNumberForAverage("first", 0);
            double avTwo = (double)GetNumberForAverage("second", 0);
            double avThree = (double)GetNumberForAverage("third", 0);
            double avFour = (double)GetNumberForAverage("fourth", 0);
            Console.WriteLine("The average of {0}, {1}, {2} and {3} is: {4}", avOne, avTwo, avThree, avFour, (avOne + avTwo + avThree + avFour) / 4);
            ReadKeyAndClear();
        }

        private static object GetNumberForAverage(string numNumber, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("Listen shit head, I said enter a NUMBER! Let's give that another go...");
            Console.WriteLine("Enter the {0} number of four to find their average...", numNumber);
            double num = 0;
            if (double.TryParse(Console.ReadLine(), out num))
                return num;
            else
                return GetNumberForAverage(numNumber, ++attempts);
        }

        private static void BasicExercise10()
        {
            double firstNum = (double)GetNumberForWonkyEquation("first", 0);
            double secondNum = (double)GetNumberForWonkyEquation("second", 0);
            double thirdNum = (double)GetNumberForWonkyEquation("third", 0);
            Console.WriteLine("Result of specified numbers {0}, {1} and {2} is: ({0} + {1}) * {2} = {3} and {0} * {1} + {1} * {2} = {4}", firstNum, secondNum, thirdNum, (firstNum + secondNum) * thirdNum, firstNum * secondNum + secondNum * thirdNum);
            ReadKeyAndClear();
        }

        private static object GetNumberForWonkyEquation(string numNumber, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("Damn it! I told you to enter a number! Now try it again!");
            Console.WriteLine("Enter the {0} number to get two wonky equations...", numNumber);
            double num = 0;
            if (double.TryParse(Console.ReadLine(), out num))
                return num;
            else
                return GetNumberForWonkyEquation(numNumber, ++attempts);
        }

        private static void BasicExercise11()
        {
            Console.WriteLine("You look older than {0}", GetAge(0));
            ReadKeyAndClear();
        }
            

        private static object GetAge(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("Come on dude! That's not an age! Give me a whole number!");
            Console.WriteLine("How old are you?");
            int age = 0;
            if (Int32.TryParse(Console.ReadLine(), out age))
                return age;
            else
                return GetAge(++attempts);
        }

        private static void BasicExercise12()
        {
            int num = (int)GetPatternNumber(0);
            for (int i = 1; i <= 4; i++)
                if (i % 2 != 0)
                    Console.WriteLine("{0} {0} {0} {0}", num);
                else
                    Console.WriteLine("{0}{0}{0}{0}", num);
            ReadKeyAndClear();
        }

        private static object GetPatternNumber(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("Come on baby! Just give me a positive whole number!");
            Console.WriteLine("Input a positive whole number to make a pattern with...");
            int num = 0;
            if (Int32.TryParse(Console.ReadLine(), out num))
                return num;
            else
                return GetPatternNumber(++attempts);
        }

        private static void BasicExercise13()
        {
            int num = (int)GetRectangleNumber(0);
            for (int i = 0; i < 5; i++)
                if (i == 0 || i == 4)
                    Console.WriteLine("{0}{0}{0}", num);
                else
                    Console.WriteLine("{0}{1}{0}", num, num.ToString().Length.Pad(' '));
            ReadKeyAndClear();
        }

        private static object GetRectangleNumber(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("Now, damn it! Didn't I say to give me a positive whole number? Well, do it!");
            Console.WriteLine("Input a positive whole number to be made a rectangle of...");
            int num = 0;
            if (Int32.TryParse(Console.ReadLine(), out num))
                return num;
            else
                return GetRectangleNumber(++attempts);
        }

        private static void BasicExercise14()
        {
            double celsTemp = (double)GetCelsiusTemp(0);
            Console.WriteLine("Kelvin = {0}", celsTemp + 273.15);
            Console.WriteLine("Fahrenheit = {0}", celsTemp * 1.8 + 32);
            ReadKeyAndClear();
        }

        private static object GetCelsiusTemp(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("Hey! I said to give me a number! That's not a number! Make with the digits!");
            Console.WriteLine("Input the celsius temperature...");
            double temp = 0;
            if (double.TryParse(Console.ReadLine(), out temp))
                return temp;
            else
                return GetCelsiusTemp(++attempts);
        }
    }
}
