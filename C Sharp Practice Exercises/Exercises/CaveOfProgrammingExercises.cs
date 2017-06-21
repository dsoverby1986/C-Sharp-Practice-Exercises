using C_Sharp_Practice_Exercises.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;

namespace C_Sharp_Practice_Exercises.Exercises
{
    class CaveOfProgrammingExercises : ConsoleReadKeyClearBehavior
    {
        public static void ShowCaveOfProgrammingExerciseMenu()
        {
            Console.WriteLine("***CAVE OF PROGRAMMING EXERCISES***\n\nChoose an option from the menu below:\n");
            foreach (KeyValuePair<int, string> option in CaveOfProgrammingExerciseMenuOptions)
                Console.WriteLine($"{(option.Key < 10 ? " " : "")}{option.Key}.) {option.Value}");
            Console.WriteLine();
            NavigateUsersRequest();
        }

        private static readonly Dictionary<int, string> CaveOfProgrammingExerciseMenuOptions = new Dictionary<int, string>()
        {
            { 1, "Execute Exercise 1  - Hello World" },
            { 2, "Execute Exercise 2  - Interactive" },
            { 3, "Execute Exercise 3  - Arrays" },
            { 4, "Execute Exercise 4  - Arrays and Loops" },
            { 5, "Execute Exercise 5  - Two Dimensional Arrays" },
            { 6, "Execute Exercise 6  - Looping through 2D Arrays" },
            { 7, "Execute Exercise 7  - Create Classes and Objects" },
            { 8, "Execute Exercise 8  - Constructors" },
            { 9, "Execute Exercise 9  - While Loops" },
            { 10, "Execute Exercise 10 - Switch Statements" },
            { 11, "Execute Exercise 11 - Do...While Loops" },
            { 12, "Execute Exercise 12 - Success?" },
            { 13, "Execute all Cave Of Programming Exercises" },
            { 14, "Return to the Main Menu" }
        };

        private static void NavigateUsersRequest()
        {
            int request = (int)GetUsersRequest(0);
            Console.Clear();
            switch (request)
            {
                case 1:
                    CaveOfProgrammingExercise1();
                    break;
                case 2:
                    CaveOfProgrammingExercise2();
                    break;
                case 3:
                    CaveOfProgrammingExercise3();
                    break;
                case 4:
                    CaveOfProgrammingExercise4();
                    break;
                case 5:
                    CaveOfProgrammingExercise5();
                    break;
                case 6:
                    CaveOfProgrammingExercise6();
                    break;
                case 7:
                    CaveOfProgrammingExercise7();
                    break;
                case 8:
                    CaveOfProgrammingExercise8();
                    break;
                case 9:
                    CaveOfProgrammingExercise9();
                    break;
                case 10:
                    CaveOfProgrammingExercise10();
                    break;
                case 11:
                    CaveOfProgrammingExercise11();
                    break;
                case 12:
                    CaveOfProgrammingExercise12();
                    break;
                case 13:
                    ExecuteAllCaveOfProgrammingExercises();
                    break;
                case 14:
                    Program.Main(new string[] { });
                    break;
                default:
                    Console.Clear();
                    ReadKeyAndClear();
                    ShowCaveOfProgrammingExerciseMenu();
                    break;
            }
            if (Program.ReturnToMainMenu)
                Program.Main(new string[] { });
            else
                ShowCaveOfProgrammingExerciseMenu();
        }

        private static int GetUsersRequest(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("Your input is invalid. Try again.");
            int request = 0;
            if (Int32.TryParse(Console.ReadLine(), out request) && CaveOfProgrammingExerciseMenuOptions.Keys.Contains(request))
                return request;
            return GetUsersRequest(++attempts);
        }

        public static void ExecuteAllCaveOfProgrammingExercises()
        {
            CaveOfProgrammingExercise1();
            CaveOfProgrammingExercise2();
            CaveOfProgrammingExercise3();
            CaveOfProgrammingExercise4();
            CaveOfProgrammingExercise5();
            CaveOfProgrammingExercise6();
            CaveOfProgrammingExercise7();
            CaveOfProgrammingExercise8();
            CaveOfProgrammingExercise9();
            CaveOfProgrammingExercise10();
            CaveOfProgrammingExercise11();
            CaveOfProgrammingExercise12();
        }

        private static void CaveOfProgrammingExercise1()
        {
            Console.WriteLine("Hello World!");
            ReadKeyAndClear();
        }

        private static void CaveOfProgrammingExercise2()
        {
            int num = (int)GetNumberFromUser(0);
            Console.WriteLine($"\nThis number is {(num >= 10 ? "big enough" : "too small")}");
            ReadKeyAndClear();
        }

        private static int GetNumberFromUser(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.\n");
            Console.WriteLine("Enter a whole number and I will classify it, generally...\n");
            int num = 0;
            if (Int32.TryParse(Console.ReadLine(), out num))
                return num;
            return GetNumberFromUser(++attempts);
        }

        private static float[] arr = new float[] { 1.34f, 12.4534f, -23.456f, 166.98789f, 46.2360634657567f };

        private static string arrString
        {
            get
            {
                string s = "{ ";
                float last = arr.ToList().Last();
                foreach (float f in arr)
                {
                    s += f.ToString();
                    if (f != last)
                        s += ", ";
                    else
                        s += " }";
                }
                return s;
            }
        }

        private static void CaveOfProgrammingExercise3()
        {
            Console.WriteLine($"I have an array that looks like this: {arrString}\n\nPress any key and I will pull out only the second value in the array...");
            Console.ReadKey();
            Console.WriteLine($"\nThis is the second value in the array: {arr[1]}");
            ReadKeyAndClear();
        }

        private static void CaveOfProgrammingExercise4()
        {
            Console.WriteLine($"I have an array that looks like this: {arrString}\n\nPress any key and I will display these values, each adjusted to the second decimal place, using a foreach loop...");
            Console.ReadKey();
            Console.WriteLine();
            foreach(float f in arr)
            {
                Console.Write(f.ToString("0.00"));
                if (f != arr[arr.Length - 1])
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }
            ReadKeyAndClear();
        }

        private static string[,] _2dArray = new string[,] { { "Janice", "Jane", "Jenny" }, { "Jack", "John", "James" } };

        private static string _2dStringArray
        {
            get
            {
                string stringArray = "{ ";
                for (int i = 0; i < _2dArray.GetLength(0); i++)
                {
                    stringArray += "{ ";
                    for (int j = 0; j < _2dArray.GetLength(1); j++)
                    {
                        stringArray += $"\"{_2dArray[i, j]}\"";
                        if (j != _2dArray.GetLength(1) - 1)
                            stringArray += ", ";
                    }
                    stringArray += " }";
                    if (i != _2dArray.GetLength(0) - 1)
                        stringArray += ", ";
                }
                stringArray += " }";
                return stringArray;
            }
        }

        private static void CaveOfProgrammingExercise5()
        {
            Console.WriteLine($"I have a two dimensional string array that looks like this: {_2dStringArray}\n");
            Console.WriteLine("Press any key and I will display the value of the third element of the second inner array...");
            Console.ReadKey();
            Console.WriteLine($"This is the value of the third element from the second inner array: {_2dArray[1, 2]}");
            ReadKeyAndClear();
        }

        private static void CaveOfProgrammingExercise6()
        {
            Console.WriteLine($"I have a two dimensional string array that looks like this: {_2dStringArray}\n");
            Console.WriteLine("Press any key and I will display this array in a table format...\n");
            Console.ReadKey();
            int longestStringLengthIn2dArray = _2dArray.GetLongestStringLength();
            for(int i = 0; i < _2dArray.GetLength(0); i++)
            {
                for(int j = 0; j < _2dArray.GetLength(1); j++)
                    Console.Write($"{_2dArray[i, j].PadRight(longestStringLengthIn2dArray + 2, ' ')}");
                Console.WriteLine();
            }
            ReadKeyAndClear();
        }

        private static void CaveOfProgrammingExercise7() =>
            ExerciseNotComplete();

        private static void CaveOfProgrammingExercise8() =>
            ExerciseNotComplete();

        private static void CaveOfProgrammingExercise9() =>
            ExerciseNotComplete();

        private static void CaveOfProgrammingExercise10() =>
            ExerciseNotComplete();

        private static void CaveOfProgrammingExercise11() =>
            ExerciseNotComplete();

        private static void CaveOfProgrammingExercise12() =>
            ExerciseNotComplete();
    }
}
