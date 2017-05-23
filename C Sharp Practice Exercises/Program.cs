using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_Sharp_Practice_Exercises.BasicExercises;
using static C_Sharp_Practice_Exercises.DataTypesExercises;
using static C_Sharp_Practice_Exercises.ConditionalStatementsExercises;

namespace C_Sharp_Practice_Exercises
{
    class Program : ConsoleReadKeyClearBehavior
    {
        public static bool ReturnToMainMenu { get; set; }

        public static void Main(string[] args)
        {
            ReturnToMainMenu = false;
            Console.ForegroundColor = ConsoleColor.Green;
            ShowMainMenu();
            Console.ResetColor();
        }

        private static readonly Dictionary<int, string> MainMenuOptions = new Dictionary<int, string>()
        {
            { 1, "Go to Basic Exercises Menu" },
            { 2, "Go to Data Type Exercises Menu" },
            { 3, "Go to Conditional Statements Exercise Menu" },
            { 4, "Execute all Basic Exercises" },
            { 5, "Execute all Data Type Exercises" },
            { 6, "Execute all Conditional Statements Exercises" },
            { 7, "Execute All Exercises" },
            { 8, "Exit" }
        };

        private static void ShowMainMenu()
        {
            Console.WriteLine("***MAIN MENU***\n\nChoose an option from the menu to get started...\n");
            foreach (KeyValuePair<int, string> option in MainMenuOptions)
                Console.WriteLine($"{option.Key}.) {option.Value}");
            Console.WriteLine();
            NavigateUsersRequest();
        }

        private static void NavigateUsersRequest()
        {
            int request = (int)GetUsersRequest(0);
            Console.Clear();
            switch (request)
            {
                case 1:
                    ShowBasicExerciseMenu();
                    break;
                case 2:
                    ShowDataTypeExerciseMenu();
                    break;
                case 3:
                    ShowConditionalStatementsExerciseMenu();
                    break;
                case 4:
                    ReturnToMainMenu = true;
                    ExecuteAllBasicExercises();
                    break;
                case 5:
                    ReturnToMainMenu = true;
                    ExecuteAllDataTypeExercises();
                    break;
                case 6:
                    ReturnToMainMenu = true;
                    ExecuteAllConditionalStatementsExercises();
                    break;
                case 7:
                    ReturnToMainMenu = true;
                    ExecuteAllExercises();
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    ReadKeyAndClear();
                    Main(new string[] { });
                    break;
            }
        }

        private static object GetUsersRequest(int attempts)
        {
            if (attempts > 0)
            {
                Console.WriteLine("\nYour input is invalid. Try again.\n");
                ReadKeyAndClear();
                ShowMainMenu();
            }
            int request = 0;
            if (Int32.TryParse(Console.ReadLine(), out request) && MainMenuOptions.Keys.Contains(request))
                return request;
            return GetUsersRequest(++attempts);
        }

        private static void ExecuteAllExercises()
        {
            ExecuteAllBasicExercises();
            ExecuteAllDataTypeExercises();
            ExecuteAllConditionalStatementsExercises();
        }
    }
}
