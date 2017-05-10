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
        public static void ExecuteAllDataTypeExercises()
        {
            DataTypeExercise1();
            DataTypeExercise2();
            DataTypeExercise3();
            DataTypeExercise4();
            DataTypeExercise5();
            DataTypeExercise6();
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
            else
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
            else
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
            else
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
            else
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
            else
                return GetOperationSymbol(++attempts);
        }

        private static void DataTypeExercise5()
        {
            double radius = (double)GetCircleRadius(0);
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * (radius * radius);
            Console.WriteLine($"\nThe circumference of the circle, based on the provided radius, is {circumference}");
            Console.WriteLine($"\nThe area of the circle, based on the provided radius, is {area}");
        }

        private static object GetCircleRadius(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nHey jerk! Just provide the input as specified!\n");
            Console.WriteLine("Input the radius of a circle to get the circle's circumference and area...");
            double radius = 0;
            if (double.TryParse(Console.ReadLine(), out radius))
                return radius;
            else
                return GetCircleRadius(++attempts);
        }

        private static void DataTypeExercise6()
        {
            Random rdm = new Random();
            int y = rdm.Next(-5, 5);
            Console.WriteLine($"{(y * y) + 2 * y + 1} = {y}\xB2 + 2({y}) + 1");
            if ((bool)UserWantsToTryForAnotherNumber(0))
                DataTypeExercise6();
        }

        private static object UserWantsToTryForAnotherNumber(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nPlease answer with 'y' or 'n'.\n");
            Console.WriteLine("Want to try a different number?");
            char answer = new char();
            if (char.TryParse(Console.ReadLine(), out answer) && Regex.IsMatch(answer.ToString(), @"[yn]+$"))
            {
                if (answer == 'y')
                    return true;
                return false;
            }
            else
                return UserWantsToTryForAnotherNumber(++attempts);
        }
    }
}