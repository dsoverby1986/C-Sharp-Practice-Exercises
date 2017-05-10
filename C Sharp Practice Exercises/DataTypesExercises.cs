using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice_Exercises
{
    class DataTypesExercises
    {
        public static void ExecuteAllDataTypeExercises()
        {
            //DataTypeExercise1();
            //DataTypeExercise2();
            DataTypeExercise3();
        }
        
        private static void DataTypeExercise1()
        {
            Console.WriteLine("Input the first letter...");
            char firstLetter = char.Parse(Console.ReadLine());
            Console.WriteLine("Input the second letter...");
            char secondLetter = char.Parse(Console.ReadLine());
            Console.WriteLine("Input the third letter...");
            char thirdLetter = char.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}", thirdLetter, secondLetter, firstLetter);
        }

        private static void DataTypeExercise2()
        {
            Console.WriteLine("Enter a number to make a triangle out of...");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number that specifies how wide the triangle should be...");
            int width = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < width - i; j++)
                    Console.Write(num);
                Console.WriteLine();
            }
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

            } while (userCred.UserId != correctUserId && userCred.Password != correctPassword);
            if (correctlyEnteredCredentials)
                Console.WriteLine("\nYou entered your credentials correctly.");
            else
                Console.WriteLine("\nYou entered your credentials incorrectly 3 times.\nYou are now locked out of the system.");
        }

        private static UserCredentials AskUserForUserIdAndPassword(UserCredentials userCred, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYou entered the wrong credentials. Try again...");
            Console.WriteLine("\nEnter the user id...");
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
    }
}
