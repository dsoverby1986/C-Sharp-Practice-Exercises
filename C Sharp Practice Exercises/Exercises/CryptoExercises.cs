using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Practice_Exercises.Exercises
{
    class CryptoExercises : ConsoleReadKeyClearBehavior
    {
        public static void ShowCryptoExerciseMenu()
        {
            Console.WriteLine("***CRYPTO EXERCISES***\n\nChoose an option from the menu below:\n");
            foreach (KeyValuePair<int, string> option in CryptoExerciseMenuOptions)
                Console.WriteLine($"{(option.Key < 10 ? " " : "")}{option.Key}.) {option.Value}");
            Console.WriteLine();
            NavigateUsersRequest();
        }

        private static readonly Dictionary<int, string> CryptoExerciseMenuOptions = new Dictionary<int, string>()
        {
            { 1, "Execute Exercise 1  - Convert Hex to Base64" },
            { 2, "Execute all Cave Of Programming Exercises" },
            { 3, "Return to the Main Menu" }
        };

        private static void NavigateUsersRequest()
        {
            int request = (int)GetUsersRequest(0);
            Console.Clear();
            switch (request)
            {
                case 1:
                    CryptoExercise1();
                    break;
                case 2:
                    ExecuteAllCryptoExercises();
                    break;
                case 3:
                    Program.Main(new string[] { });
                    break;
                default:
                    Console.Clear();
                    ReadKeyAndClear();
                    ShowCryptoExerciseMenu();
                    break;
            }
            if (Program.ReturnToMainMenu)
                Program.Main(new string[] { });
            else
                ShowCryptoExerciseMenu();
        }

        private static int GetUsersRequest(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("Your input is invalid. Try again.");
            int request = 0;
            if (Int32.TryParse(Console.ReadLine(), out request) && CryptoExerciseMenuOptions.Keys.Contains(request))
                return request;
            return GetUsersRequest(++attempts);
        }

        public static void ExecuteAllCryptoExercises()
        {
            CryptoExercise1();
        }

        private static void CryptoExercise1() =>
            ExerciseNotComplete();
    }
}
