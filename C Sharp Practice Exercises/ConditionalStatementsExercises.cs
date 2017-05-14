using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace C_Sharp_Practice_Exercises
{
    class ConditionalStatementsExercises : ConsoleReadKeyClearBehavior
    {
        public static void ExecuteAllConditionalStatementsExercises()
        {
            ConditionalStatementExercise1();
            ConditionalStatementExercise2();
            ConditionalStatementExercise3();
            ConditionalStatementExercise4();
            ConditionalStatementExercise5();
            ConditionalStatementExercise6();
            ConditionalStatementExercise7();
            ConditionalStatementExercise8();
            //ConditionalStatementExercise9();
            //ConditionalStatementExercise10();
            //ConditionalStatementExercise11();
            //ConditionalStatementExercise12();
            //ConditionalStatementExercise13();
            //ConditionalStatementExercise14();
            //ConditionalStatementExercise15();
            //ConditionalStatementExercise16();
            //ConditionalStatementExercise17();
            //ConditionalStatementExercise18();
            //ConditionalStatementExercise19();
            //ConditionalStatementExercise20();
            //ConditionalStatementExercise21();
            //ConditionalStatementExercise22();
            //ConditionalStatementExercise23();
            //ConditionalStatementExercise24();
            //ConditionalStatementExercise25();
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

        private static void ConditionalStatementExercise2()
        {
            int num = (int)GetOddEvenNumber(0);
            Console.WriteLine("\n{0} is an {1} integer", num, num % 2 == 0 ? "even" : "odd");
            ReadKeyAndClear();
        }

        private static object GetOddEvenNumber(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYou didn't follow the instructions that I gave you. Try again.\n");
            Console.WriteLine("Enter a whole number and I will tell you whether it's odd or even...\n");
            int num = 0;
            if (Int32.TryParse(Console.ReadLine(), out num))
                return num;
            return GetOddEvenNumber(++attempts);
        }

        private static void ConditionalStatementExercise3()
        {
            double num = (double)GetPositiveNegativeNumber(0);
            Console.WriteLine("\n{0} is a {1} number", num, num > 0 ? "positive" : num == 0 ? "unsigned" : "negative");
            bool userWantsToGoAgain = (bool)UserWantsToGoAgain(0);
            if(userWantsToGoAgain)
            {
                Console.Clear();
                ConditionalStatementExercise3();
            }
            Console.Clear();
        }

        private static object GetPositiveNegativeNumber(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYou didn't enter a number. Try again.\n");
            Console.WriteLine("Enter a number and I will tell you whether it's positive or negative...\n");
            double num = 0;
            if (double.TryParse(Console.ReadLine(), out num))
                return num;
            return GetPositiveNegativeNumber(++attempts);
        }

        private static object UserWantsToGoAgain(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour response did not make sense. Try again.\n");
            Console.WriteLine("\nWould you like to try another number? (y/n)\n");
            string response = Console.ReadLine().ToLower();
            if (response == "y" || response == "yes")
                return true;
            else if (response == "n" || response == "no")
                return false;
            return UserWantsToGoAgain(++attempts);

        }

        private static void ConditionalStatementExercise4()
        {
            int year = (int)GetYear(0);
            bool isLeapYear = DetermineIfYearIsLeap(year);
            Console.WriteLine("\n{0} is {1}a leap year", year, isLeapYear ? "" : "not ");
            bool tryAnother = (bool)UserWantsToDoAnotherYear(0);
            Console.Clear();
            if (tryAnother)
                ConditionalStatementExercise4();
        }

        private static object GetYear(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.\n");
            Console.WriteLine("Enter a year and I will tell you if it is a leap year or not...\n");
            int year = 0;
            if (Int32.TryParse(Console.ReadLine(), out year))
                return year;
            return GetYear(++attempts);
        }

        private static bool DetermineIfYearIsLeap(int year)
        {
            if (year % 4 == 0)
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        return true;
                }
                else
                    return true;
            return false;
        }

        private static object UserWantsToDoAnotherYear(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour response didn't make sense. Try again.\n");
            Console.WriteLine("\nWould you like to try another year? (y/n)\n");
            string response = Console.ReadLine().ToLower();
            if (Regex.IsMatch(response, @"\b(y|yes)\b"))
                return true;
            else if (Regex.IsMatch(response, @"\b(n|no)\b"))
                return false;
            return UserWantsToDoAnotherYear(++attempts);
        }

        private static void ConditionalStatementExercise5()
        {
            int age = (int)GetAge(0);
            Console.WriteLine("\nYou are {0}eligible to vote", age < 18 ? "not " : "");
            ReadKeyAndClear();
        }

        private static object GetAge(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.");
            Console.WriteLine("Enter your age to check voting eligibility...\n");
            int age = 0;
            if (Int32.TryParse(Console.ReadLine(), out age))
                return age;
            return GetAge(++attempts);
        }

        private static void ConditionalStatementExercise6()
        {
            double num = (double)GetRelativeNumber(0);
            Console.WriteLine("\nThe value of n is {0}", num == 0 ? "0" : num > 0 ? "1" : "-1");
            bool tryAnother = (bool)FindOutIfUserWantsToTryAnotherNumber(0);
            Console.Clear();
            if (tryAnother)
                ConditionalStatementExercise6();
        }

        private static object GetRelativeNumber(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.\n");
            Console.WriteLine("Enter a number. If the number is greater than 0, 1 will be returned. If the number is 0, 0 will be returned. If the number is less than 0, -1 will be returned.\n");
            double num = 0;
            if (double.TryParse(Console.ReadLine(), out num))
                return num;
            return GetRelativeNumber(++attempts);
        }

        private static object FindOutIfUserWantsToTryAnotherNumber(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour reponse didn't make sense. Try again.\n");
            Console.WriteLine("\nWould you like to try another number?\n");
            string response = Console.ReadLine().ToLower();
            if (Regex.IsMatch(response, @"\b(y|yes)\b"))
                return true;
            else if (Regex.IsMatch(response, @"\b(n|no)\b"))
                return false;
            return FindOutIfUserWantsToTryAnotherNumber(++attempts);
        }

        private static void ConditionalStatementExercise7()
        {
            double height = (double)GetUsersHeight(0);
            Console.WriteLine("\nYou're a {0}", height <= 147 ? "dwarf" : height >= 213.36 ? "giant" : "person of standard height");
            ReadKeyAndClear();
        }

        private static object GetUsersHeight(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.\n");
            Console.WriteLine("Enter your height in centimeters and I will categorize your height...\n");
            double height = 0;
            if (double.TryParse(Console.ReadLine(), out height))
                return height;
            return GetUsersHeight(++attempts);
        }

        private static void ConditionalStatementExercise8()
        {
            Console.WriteLine("Enter three numbers and I will tell you which of them is the largest.");
            double[] nums = new double[3];
            Dictionary<int, string> ordinals = new Dictionary<int, string>()
            {
                { 0, "first" },
                { 1, "second" },
                { 2, "third" }
            };
            for (int i = 0; i < nums.Length; i++)
                nums[i] = (double)GetNumberFromUser(ordinals[i], 0);
            Array.Sort(nums);
            Console.WriteLine("\nOf the numbers you entered, {0} is the largest.", nums[nums.Length - 1]);
            bool userWantsToGoAgain = (bool)FindOutIfTheUserWantsToGoAgain(0);
            Console.Clear();
            if (userWantsToGoAgain)
                ConditionalStatementExercise8();
        }

        private static object GetNumberFromUser(string numNumber, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input was invaild. Try again, please.");
            Console.WriteLine("\nEnter the {0} number...\n", numNumber);
            double num = 0;
            if (double.TryParse(Console.ReadLine(), out num))
                return num;
            return GetNumberFromUser(numNumber, ++attempts);
        }

        private static object FindOutIfTheUserWantsToGoAgain(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour response didn't make any sense. Try again, please.");
            Console.WriteLine("\nWould you like to try another three numbers? (y/n)\n");
            string response = Console.ReadLine().ToLower();
            if (Regex.IsMatch(response, @"\b(y|yes)\b"))
                return true;
            else if (Regex.IsMatch(response, @"\b(n|no)\b"))
                return false;
            return FindOutIfTheUserWantsToGoAgain(++attempts);
        }

        private static void ConditionalStatementExercise9()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise10()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise11()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise12()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise13()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise14()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise15()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise16()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise17()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise18()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise19()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise20()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise21()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise22()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise23()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise24()
        {
            throw new NotImplementedException();
        }

        private static void ConditionalStatementExercise25()
        {
            throw new NotImplementedException();
        }
    }
}
