using C_Sharp_Practice_Exercises.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Sharp_Practice_Exercises
{
    class DataTypesExercises : ConsoleReadKeyClearBehavior
    {
        public static void ShowDataTypeExerciseMenu()
        {
            Console.WriteLine("***DATA TYPE EXERCISES***\n\nChoose an option from the menu below:\n");
            foreach (KeyValuePair<int, string> option in DataTypeExerciseMenuOptions)
                Console.WriteLine($"{(option.Key < 10 ? " " : "")}{option.Key}.) {option.Value}");
            Console.WriteLine();
            NavigateUsersRequest();
        }

        private static readonly Dictionary<int, string> DataTypeExerciseMenuOptions = new Dictionary<int, string>()
        {
            { 1, "Execute Exercise 1  - Reverse Letters" },
            { 2, "Execute Exercise 2  - Draw Triangle" },
            { 3, "Execute Exercise 3  - Login" },
            { 4, "Execute Exercise 4  - Calculator" },
            { 5, "Execute Exercise 5  - Calculate circumference and area of circle" },
            { 6, "Execute Exercise 6  - Random function plugger" },
            { 7, "Execute Exercise 7  - Get Speed" },
            { 8, "Execute Exercise 8  - Get surface area and volume of sphere" },
            { 9, "Execute Exercise 9  - Classify Character" },
            { 10, "Execute Exercise 10 - Odd/Even/Both" },
            { 11, "Execute Exercise 11 - Binary Form" },
            { 12, "Execute All Data Type Exercises" },
            { 13, "Return to the Main Menu" }
        };

        private static void NavigateUsersRequest()
        {
            int request = (int)GetUsersRequest(0);
            Console.Clear();
            switch (request)
            {
                case 1:
                    DataTypeExercise1();
                    break;
                case 2:
                    DataTypeExercise2();
                    break;
                case 3:
                    DataTypeExercise3();
                    break;
                case 4:
                    DataTypeExercise4();
                    break;
                case 5:
                    DataTypeExercise5();
                    break;
                case 6:
                    DataTypeExercise6();
                    break;
                case 7:
                    DataTypeExercise7();
                    break;
                case 8:
                    DataTypeExercise8();
                    break;
                case 9:
                    DataTypeExercise9();
                    break;
                case 10:
                    DataTypeExercise10();
                    break;
                case 11:
                    DataTypeExercise11();
                    break;
                case 12:
                    ExecuteAllDataTypeExercises();
                    break;
                case 13:
                    Program.Main(new string[] { });
                    break;
                default:
                    Console.Clear();
                    ReadKeyAndClear();
                    ShowDataTypeExerciseMenu();
                    break;
            }
            if (Program.ReturnToMainMenu)
                Program.Main(new string[] { });
            else
                ShowDataTypeExerciseMenu();
        }

        private static object GetUsersRequest(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("Your input is invalid. Try again.");
            int request = 0;
            if (Int32.TryParse(Console.ReadLine(), out request) && DataTypeExerciseMenuOptions.Keys.Contains(request))
                return request;
            return GetUsersRequest(++attempts);
        }

        public static void ExecuteAllDataTypeExercises()
        {
            DataTypeExercise1();
            DataTypeExercise2();
            DataTypeExercise3();
            DataTypeExercise4();
            DataTypeExercise5();
            DataTypeExercise6();
            DataTypeExercise7();
            DataTypeExercise8();
            DataTypeExercise9();
            DataTypeExercise10();
            DataTypeExercise11();
        }
        
        private static void DataTypeExercise1()
        {
            char firstLetter = (char)GetLetter("first", 0);
            char secondLetter = (char)GetLetter("second", 0);
            char thirdLetter = (char)GetLetter("third", 0);
            Console.WriteLine("\n{0} {1} {2}", thirdLetter, secondLetter, firstLetter);
            ReadKeyAndClear();
        }

        private static object GetLetter(string numNumber, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nI just want you to enter a single character. Just a letter. Let's give it another try.\n");
            Console.WriteLine("Input the {0} letter...", numNumber);
            char letter = new char();
            if (char.TryParse(Console.ReadLine(), out letter) && Regex.IsMatch(letter.ToString(), @"^[a-zA-Z]+$"))
                return letter;
            return GetLetter(numNumber, ++attempts);
        }

        private static void DataTypeExercise2()
        {
            double num = (double)GetTriangleNumber(0);
            int width = (int)GetTriangleWidth(0);
            Console.Write("\n");
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < width - i; j++)
                    Console.Write(num);
                Console.WriteLine();
            }
            ReadKeyAndClear();
        }

        private static object GetTriangleNumber(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYou didn't enter a number. Get with the program, buddy.\n");
            Console.WriteLine("Enter a number to make a triangle out of...");
            double num = 0;
            if (double.TryParse(Console.ReadLine(), out num))
                return num;
            return GetTriangleNumber(++attempts);
        }

        private static object GetTriangleWidth(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYou didn't enter a positive whole number, greater than one. Get with the program, pal.\n");
            Console.WriteLine("Enter a positive integer, greater than one, as the width of the triangle...");
            int num = 0;
            if (Int32.TryParse(Console.ReadLine(), out num) && num > 1)
                return num;
            return GetTriangleWidth(++attempts);
        }

        private static void DataTypeExercise3()
        {
            string correctUserId = "dsoverby1986@gmail.com";
            string correctPassword = "fK%jOR1:c6";
            UserCredentials userCred = new UserCredentials();
            int attempts = 0;
            bool correctlyEnteredCredentials = true;
            do
            {
                if (attempts < 3)
                {
                    userCred = AskUserForUserIdAndPassword(userCred, attempts);
                    attempts++;
                }
                else
                {
                    correctlyEnteredCredentials = false;
                    break;
                }

            } while (userCred.UserId != correctUserId || userCred.Password != correctPassword);
            if (correctlyEnteredCredentials)
                Console.WriteLine("\nYou entered your credentials correctly.");
            else
                Console.WriteLine("\nYou entered your credentials incorrectly 3 times.\nYou are now locked out of the system.");
            ReadKeyAndClear();
        }

        private static UserCredentials AskUserForUserIdAndPassword(UserCredentials userCred, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour entered the wrong credentials. Try again...\n");
            Console.WriteLine("Enter the user id...");
            userCred.UserId = Console.ReadLine();
            Console.WriteLine("\nEnter the password...");
            userCred.Password = Console.ReadLine();
            return userCred;
        }

        private class UserCredentials
        {
            public string UserId { get; set; }
            public string Password { get; set; }
        }

        private static void DataTypeExercise4()
        {
            double firstNum = (double)GetOperationNumber("first", 0);
            double secondNum = (double)GetOperationNumber("second", 0);
            char operation = (char)GetOperationSymbol(0);
            string equation = $"\n{firstNum} {operation} {secondNum} = ";
            switch (operation)
            {
                case '+':
                    equation += $"{firstNum + secondNum}";
                    break;
                case '-':
                    equation += $"{firstNum - secondNum}";
                    break;
                case '*':
                    equation += $"{firstNum * secondNum}";
                    break;
                case '/':
                    equation += $"{firstNum / secondNum}";
                    break;
                case '%':
                    equation += $"{firstNum % secondNum}";
                    break;
                default:
                    break;
            }
            Console.WriteLine(equation);
            ReadKeyAndClear();
        }

        private static object GetOperationNumber(string numNumber, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nCheck it out, I said to do one thing and then you did something different. Try it my way next time, buddy.\n");
            Console.WriteLine("Input the {0} number to have an operation performed on it...", numNumber);
            double num = 0;
            if (double.TryParse(Console.ReadLine(), out num))
                return num;
            return GetOperationNumber(numNumber, ++attempts);
        }

        private static object GetOperationSymbol(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nI know this may be confusing for you but I just want you to do what I'm asking.\n");
            Console.WriteLine("Enter the operation symbol of the operation you want to perform on the two numbers...");
            char operationSymbol = new char();
            if (char.TryParse(Console.ReadLine(), out operationSymbol) && Regex.IsMatch(operationSymbol.ToString(), @"[-+*/%]+$"))
                return operationSymbol;
            return GetOperationSymbol(++attempts);
        }

        private static void DataTypeExercise5()
        {
            double radius = (double)GetCircleRadius(0);
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * (radius * radius);
            Console.WriteLine($"\nThe circumference of the circle, based on the provided radius, is {circumference}");
            Console.WriteLine($"\nThe area of the circle, based on the provided radius, is {area}");
            ReadKeyAndClear();
        }

        private static object GetCircleRadius(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nHey jerk! Just provide the input as specified!\n");
            Console.WriteLine("Input the radius of a circle to get the circle's circumference and area...");
            double radius = 0;
            if (double.TryParse(Console.ReadLine(), out radius))
                return radius;
            return GetCircleRadius(++attempts);
        }

        private static void DataTypeExercise6()
        {
            Random rdm = new Random();
            int y = rdm.Next(-5, 5);
            Console.WriteLine($"{(y * y) + 2 * y + 1} = {y}\xB2 + 2({y}) + 1");
            if ((bool)UserWantsToTryForAnotherNumber(0))
                DataTypeExercise6();
            Console.Clear();
        }

        private static object UserWantsToTryForAnotherNumber(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nPlease answer with 'y' or 'n' only.\n");
            Console.WriteLine("Want to try a different number? (y/n)");
            char answer = new char();
            if (char.TryParse(Console.ReadLine(), out answer) && Regex.IsMatch(answer.ToString(), @"[yn]+$"))
            {
                if (answer == 'y')
                    return true;
                return false;
            }
            return UserWantsToTryForAnotherNumber(++attempts);
        }

        private static void DataTypeExercise7()
        {
            Console.WriteLine("Let's calculate the speed required to travel a specified distance over a specified time.\n");
            double distance = (double)GetDistance(0);
            int hours = (int)GetTime("hours", 0);
            int minutes = (int)GetTime("minutes", 0);
            int seconds = (int)GetTime("seconds", 0);
            double calcHours = CalculateHours(hours, minutes, seconds);
            double calcSeconds = CalculateSeconds(calcHours);
            Dictionary<string, double> rates = new Dictionary<string, double>()
            {
                { "miles/hour", distance / calcHours },
                { "kilometers/hour", distance * 1.60934 / calcHours },
                { "meters/second", distance * 1609.34 / calcSeconds },
                { "feet/second", distance * 5280 / calcSeconds }
            };
            Console.WriteLine();
            foreach (KeyValuePair<string, double> rate in rates)
                Console.WriteLine($"Your speed in {rate.Key} is {rate.Value}");
            ReadKeyAndClear();
        }

        private static object GetDistance(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nBuddy Boy! I said give me a number for the distance! Do that instead of what you just did.\n");
            Console.WriteLine("Enter a number that represents the distance traveled in miles...");
            double distance = 0;
            if (double.TryParse(Console.ReadLine(), out distance))
                return distance;
            return GetDistance(++attempts);
        }

        private static object GetTime(string type, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nCome on, pal! I said give me a positive whole number for the {0}! Give it another go.", type);
            Console.WriteLine("\nEnter a positive whole number that represents the {0}...", type);
            int time = 0;
            if (Int32.TryParse(Console.ReadLine(), out time) && time > 0)
                return time;
            return GetTime(type, ++attempts);
        }

        private static double CalculateHours(int hours, int minutes, int seconds)
        {
            double calculatedMinutes = minutes + seconds / 60;
            return hours + calculatedMinutes / 60;
        }

        private static double CalculateSeconds(double hours) =>
            hours * 3600;

        private static void DataTypeExercise8()
        {
            Console.WriteLine("Let's get the surface area and volume of a sphere, based on it's radius.");
            double radius = (double)GetSphereRadius(0);
            Console.WriteLine("\nThe surface area of the sphere is {0}", 4 * Math.PI * (radius * radius));
            Console.WriteLine("The volume of the sphere is {0}", (4 / 3) * Math.PI * (radius * radius * radius));
            ReadKeyAndClear();
        }

        private static object GetSphereRadius(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nSweetheart, I said enter a number for the radius. Try again!");
            Console.WriteLine("\nEnter a number for the radius of the sphere...");
            double radius = 0;
            if (double.TryParse(Console.ReadLine(), out radius))
                return radius;
            return GetSphereRadius(++attempts);
        }

        private static void DataTypeExercise9()
        {
            char _char = (char)GetCharacter(0);
            string analysis = "\n" + _char.GetAnalysis();
            Console.WriteLine(analysis);
            bool tryAnother = CheckIfUserWantsToTryAnotherCharacter(0);
            if (tryAnother)
            {
                Console.Clear();
                DataTypeExercise9();
            }
            ReadKeyAndClear();
        }

        private static object GetCharacter(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nHey little baby, I said enter a single character. So, just do that.\n");
            Console.WriteLine("Enter a single character to have it's general description analyzed...");
            char _char = new char();
            if (char.TryParse(Console.ReadLine(), out _char))
                return _char;
            return GetCharacter(++attempts);
        }

        private static bool CheckIfUserWantsToTryAnotherCharacter(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nI didn't catch that. Say again...");
            Console.WriteLine("\nWould you like to try another character? (y/n)");
            string response = Console.ReadLine().ToLower();
            if (response == "y" || response == "yes")
                return true;
            else if (response == "n" || response == "no")
                return false;
            return CheckIfUserWantsToTryAnotherCharacter(++attempts);
        }

        private static void DataTypeExercise10()
        {
            Console.WriteLine("I want you to enter two numbers and I will tell you whether or not they are both odd or even.");
            TwoNumbers twoNums = new TwoNumbers();
            Console.WriteLine("\n" + twoNums.Analysis);
            ReadKeyAndClear();
        }

        private class TwoNumbers
        {
            public TwoNumbers()
            {
                FirstNumber = (int)GetOddEvenNumber("first", 0);
                SecondNumber = (int)GetOddEvenNumber("second", 0);
                Analysis = AnalyzeNumbers();
            }

            private int FirstNumber;
            private int SecondNumber;
            public string Analysis { get; set; }

            Dictionary<int, string> possibleAnalyses = new Dictionary<int, string>()
            {
                { 0, "Both numbers are odd" },
                { 1, "Both numbers are even" },
                { 2, "One number is odd and one number is even" }
            };

            private enum Analyses
            {
                ODD,
                EVEN,
                MIXED
            };

            private static object GetOddEvenNumber(string numNumber, int attempts)
            {
                if (attempts > 0)
                    Console.WriteLine("\nHey honey, I wanted you to enter a whole number. So, just give me that number, babe.");
                Console.WriteLine("\nEnter the {0} whole number...", numNumber);
                int num = 0;
                if (Int32.TryParse(Console.ReadLine(), out num))
                    return num;
                return GetOddEvenNumber(numNumber, ++attempts);
            }

            private string AnalyzeNumbers()
            {
                int result;
                if (FirstNumber % 2 == 0 && SecondNumber % 2 == 0)
                    result = (int)Analyses.EVEN;
                else if (FirstNumber % 2 != 0 && SecondNumber % 2 != 0)
                    result = (int)Analyses.ODD;
                else
                    result = (int)Analyses.MIXED;
                return possibleAnalyses[result];
            }
        }

        private static void DataTypeExercise11()
        {
            int num = (int)GetNumberToConvert(0);
            Console.WriteLine("\n{0}", Convert.ToString(num, 2));
            ReadKeyAndClear();
        }

        private static int GetNumberToConvert(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nListen honey babydoll sweet cheeks, I just wanted you to do one thing and you couldn't even do that!\n");
            Console.WriteLine("Enter a number to get it's binary form...");
            int num = 0;
            if (Int32.TryParse(Console.ReadLine(), out num))
                return num;
            return GetNumberToConvert(++attempts);
        }
    }
}