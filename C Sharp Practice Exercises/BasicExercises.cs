using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice_Exercises
{
    class BasicExercises
    {
        public static void ExecuteAllBasicExercises()
        {
            BasicExercise1();
            Console.WriteLine();
            BasicExercise2();
            Console.WriteLine();
            BasicExercise3();
            Console.WriteLine();
            BasicExercise4();
            Console.WriteLine();
            BasicExercise5();
            Console.WriteLine();
            BasicExercise6();
            Console.WriteLine();
            BasicExercise7();
            Console.WriteLine();
            BasicExercise8();
            Console.WriteLine();
            BasicExercise9();
            Console.WriteLine();
            BasicExercise10();
            Console.WriteLine();
            BasicExercise11();
            Console.WriteLine();
            BasicExercise12();
            Console.WriteLine();
            BasicExercise13();
            Console.WriteLine();
            BasicExercise14();
        }

        private static void BasicExercise1()
        {
            Console.WriteLine("Hello: Shane Overby");
        }

        private static void BasicExercise2()
        {
            Console.WriteLine("12 + 33 = " + (12 + 33));
        }

        private static void BasicExercise3()
        {
            Console.WriteLine("276 / 14 = " + (276 / 14));
        }

        private static void BasicExercise4()
        {
            Console.WriteLine("-1 + 4 * 6 = " + (-1 + 4 * 6));
            Console.WriteLine("(35 + 5) % 7 = " + ((35 + 5) % 7));
            Console.WriteLine("14 + -4 * 6 / 11 = " + (14 + -4 * 6 / 11));
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + (2 + 15 / 6 * 1 - 7 % 2));
        }

        private static void BasicExercise5()
        {
            Console.WriteLine("Input the first number...");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Input the second number...");
            string secondNumber = Console.ReadLine();
            Console.WriteLine("First Number: " + secondNumber);
            Console.WriteLine("Second Number: " + firstNumber);
        }

        private static void BasicExercise6()
        {
            Console.WriteLine("Input the first integer to multiply...");
            int factorOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input the second integer to multiply...");
            int factorTwo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input the third integer to multiply...");
            int factorThree = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} * {2} = {3}", factorOne, factorTwo, factorThree, factorOne * factorTwo * factorThree);
        }

        private static void BasicExercise7()
        {
            Console.WriteLine("Enter the first number to add, subtract, multiply and divide...");
            int numOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number to add, subtract, multiply and divide...");
            int numTwo = Int32.Parse(Console.ReadLine());
            Console.WriteLine(numOne + " + " + numTwo + "= " + (numOne + numTwo));
            Console.WriteLine(numOne + " - " + numTwo + "= " + (numOne - numTwo));
            Console.WriteLine(numOne + " * " + numTwo + "= " + (numOne * numTwo));
            Console.WriteLine(numOne + " / " + numTwo + "= " + (numOne / numTwo));
            Console.WriteLine(numOne + " mod " + numTwo + "= " + (numOne % numTwo));
        }

        private static void BasicExercise8()
        {
            Console.WriteLine("Enter a number to get it's multiplication table...");
            int multNum = Int32.Parse(Console.ReadLine());
            for (var i = 0; i <= 10; i++)
                Console.WriteLine("{0} * {1} = {2}", multNum, i, multNum * i);
        }

        private static void BasicExercise9()
        {
            Console.WriteLine("Enter the first number of four to find their average...");
            int avOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number of four to find their average...");
            int avTwo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number of four to find their average...");
            int avThree = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number of four to find their average...");
            int avFour = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The average of {0}, {1}, {2} and {3} is: {4}", avOne, avTwo, avThree, avFour, (avOne + avTwo + avThree + avFour) / 4);
        }

        private static void BasicExercise10()
        {
            Console.WriteLine("Enter the first number to get two wonky equations...");
            int firstNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number to get two wonky equations...");
            int secondNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number to get two wonky equations...");
            int thirdNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Result of specified numbers " + firstNum + ", " + secondNum + " and " + thirdNum + " is: (" + firstNum + " + " + secondNum + ") * " + thirdNum + " = " + ((firstNum + secondNum) * thirdNum) + " and " + firstNum + " * " + secondNum + " + " + secondNum + " * " + thirdNum + " = " + (firstNum * secondNum + secondNum * thirdNum));
        }

        private static void BasicExercise11()
        {
            Console.WriteLine("How old are you?");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You look older than {0}", age);
        }

        private static void BasicExercise12()
        {
            Console.WriteLine("Input a number to make a pattern with...");
            int num = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= 4; i++)
                if (i % 2 != 0)
                    Console.WriteLine("{0} {0} {0} {0}", num);
                else
                    Console.WriteLine("{0}{0}{0}{0}", num);
        }

        private static void BasicExercise13()
        {
            Console.WriteLine("Input the number to be made a rectangle of...");
            int num = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
                if (i == 0 || i == 4)
                    Console.WriteLine("{0}{0}{0}", num);
                else
                    Console.WriteLine("{0} {0}", num);

        }

        private static void BasicExercise14()
        {
            Console.WriteLine("Input the celsius temperature...");
            double celsTemp = double.Parse(Console.ReadLine());
            Console.WriteLine("Kelvin = {0}", (celsTemp * 1.8 + 32));
            Console.WriteLine("Fahrenheit = {0}", (celsTemp + 273.15));
        }
    }
}
