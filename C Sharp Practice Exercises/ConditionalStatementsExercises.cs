using C_Sharp_Practice_Exercises.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;

namespace C_Sharp_Practice_Exercises
{
    class ConditionalStatementsExercises : ConsoleReadKeyClearBehavior
    {
        public static void ShowConditionalStatementsExerciseMenu()
        {
            Console.WriteLine("***CONDITIONAL STATEMENT EXERCISES***\n\nChoose an option from the menu below:\n");
            foreach (KeyValuePair<int, string> option in ConditionalStatementExerciseMenuOptions)
                Console.WriteLine($"{(option.Key < 10 ? " " : "")}{option.Key}.) {option.Value}");
            NavigateUsersRequest();
        }

        private static readonly Dictionary<int, string> ConditionalStatementExerciseMenuOptions = new Dictionary<int, string>()
        {
            { 1, "Execute Exercise 1  - Check number eqaulity" },
            { 2, "Execute Exercise 2  - Odd or Even" },
            { 3, "Execute Exercise 3  - Positive or Negative" },
            { 4, "Execute Exercise 4  - Leap year" },
            { 5, "Execute Exercise 5  - Voting Eligibility" },
            { 6, "Execute Exercise 6  - Classify Numbers" },
            { 7, "Execute Exercise 7  - Classify Height" },
            { 8, "Execute Exercise 8  - Largest Number" },
            { 9, "Execute Exercise 9  - Point Quadrant Locator" },
            { 10, "Execute Exercise 10 - Admission Eligibility" },
            { 11, "Execute Exercise 11 - Calculate root of quadratic equation" },
            { 12, "Execute Exercise 12 - Get student subject data" },
            { 13, "Execute Exercise 13 - Describe Temperature Condition" },
            { 14, "Execute Exercise 14 - Classify Triangle" },
            { 15, "Execute Exercise 15 - Validate Triangle" },
            { 16, "Execute Exercise 16 - Vowel or Consonant" },
            { 17, "Execute Exercise 17 - Calculate Profit/Loss" },
            { 18, "Execute Exercise 18 - Electricity Bill" },
            { 19, "Execute Exercise 19 - Grade Description" },
            { 20, "Execute Exercise 20 - Day of Week" },
            { 21, "Execute Exercise 21 - Number Word" },
            { 22, "Execute Exercise 22 - Month of Year" },
            { 23, "Execute Exercise 23 - Number of days in Month" },
            { 24, "Execute Exercise 24 - Get Area of Shape" },
            { 25, "Execute Exercise 25 - Calculator" },
            { 26, "Execute all Conditional Statement Exercises" },
            { 27, "Return to the Main Menu" }
        };

        private static void NavigateUsersRequest()
        {
            int request = (int)GetUsersRequest(0);
            Console.Clear();
            switch (request)
            {
                case 1:
                    ConditionalStatementExercise1();
                    break;
                case 2:
                    ConditionalStatementExercise2();
                    break;
                case 3:
                    ConditionalStatementExercise3();
                    break;
                case 4:
                    ConditionalStatementExercise4();
                    break;
                case 5:
                    ConditionalStatementExercise5();
                    break;
                case 6:
                    ConditionalStatementExercise6();
                    break;
                case 7:
                    ConditionalStatementExercise7();
                    break;
                case 8:
                    ConditionalStatementExercise8();
                    break;
                case 9:
                    ConditionalStatementExercise9();
                    break;
                case 10:
                    ConditionalStatementExercise10();
                    break;
                case 11:
                    ConditionalStatementExercise11();
                    break;
                case 12:
                    ConditionalStatementExercise12();
                    break;
                case 13:
                    ConditionalStatementExercise13();
                    break;
                case 14:
                    ConditionalStatementExercise14();
                    break;
                case 15:
                    ConditionalStatementExercise15();
                    break;
                case 16:
                    ConditionalStatementExercise16();
                    break;
                case 17:
                    ConditionalStatementExercise17();
                    break;
                case 18:
                    ConditionalStatementExercise18();
                    break;
                case 19:
                    ConditionalStatementExercise19();
                    break;
                case 20:
                    ConditionalStatementExercise20();
                    break;
                case 21:
                    ConditionalStatementExercise21();
                    break;
                case 22:
                    ConditionalStatementExercise22();
                    break;
                case 23:
                    ConditionalStatementExercise23();
                    break;
                case 24:
                    ConditionalStatementExercise24();
                    break;
                case 25:
                    ConditionalStatementExercise25();
                    break;
                case 26:
                    ExecuteAllConditionalStatementsExercises();
                    break;
                case 27:
                    Program.Main(new string[] { });
                    break;
                default:
                    Console.Clear();
                    ReadKeyAndClear();
                    ShowConditionalStatementsExerciseMenu();
                    break;
            }
            if (Program.ReturnToMainMenu)
                Program.Main(new string[] { });
            else
                ShowConditionalStatementsExerciseMenu();
        }

        private static object GetUsersRequest(int attempts)
        {
            if(attempts > 0)
                Console.WriteLine("Your input is invalid. Try again.");
            int request = 0;
            if (Int32.TryParse(Console.ReadLine(), out request) && ConditionalStatementExerciseMenuOptions.Keys.Contains(request))
                return request;
            return GetUsersRequest(++attempts);
        }

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
            ConditionalStatementExercise9();
            ConditionalStatementExercise10();
            ConditionalStatementExercise11();
            ConditionalStatementExercise12();
            ConditionalStatementExercise13();
            ConditionalStatementExercise14();
            ConditionalStatementExercise15();
            ConditionalStatementExercise16();
            ConditionalStatementExercise17();
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
            Console.WriteLine("Enter an X coordinate and a Y coordinate and I will tell you the general location of their point.");
            int quadX = GetQuadrantIndicator((double)GetCoordinate("X", 0));
            int quadY = GetQuadrantIndicator((double)GetCoordinate("Y", 0));
            string generalArea = generalAreas.First(q => q.Key[0] == quadX && q.Key[1] == quadY).Value;
            Console.WriteLine("\nYour coordinates place the point {0}", generalArea);
            ReadKeyAndClear();
        }

        private static object GetCoordinate(string coord, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.\n");
            Console.WriteLine("\nEnter a number to represent the {0} coordinate\n", coord);
            double coordNum = 0;
            if (double.TryParse(Console.ReadLine(), out coordNum))
                return coordNum;
            return GetCoordinate(coord, ++attempts);
        }
        private static int GetQuadrantIndicator(double coord)
        {
            return coord != 0 ? (int)(coord / (coord * (coord > 0 ? 1 : -1))) : 0;
        }

        private static readonly Dictionary<int[], string> generalAreas = new Dictionary<int[], string>()
        {
            { new int[] { 0, 0 }, "on the axis" },
            { new int[] { 0, 1 }, "in the northern hemisphere" },
            { new int[] { 0, -1 }, "in the southern hemisphere" },
            { new int[] { 1, 0 }, "in the eastern hemisphere" },
            { new int[] { -1, 0 }, "in the western hemisphere" },
            { new int[] { 1, 1 }, "in the first quadrant" },
            { new int[] { 1, -1 }, "in the second quadrant" },
            { new int[] { -1, -1 }, "in the third quadrant" },
            { new int[] { -1, 1 }, "in the fourth quadrant" }
        };

        private static void ConditionalStatementExercise10()
        {
            Console.WriteLine("Enter your marks in maths, physics and chemistry to have your eligibility for admission determined.");
            List<double> factors = new List<double>(new double[] { (double)GetMarks("maths", 0), (double)GetMarks("physics", 0), (double)GetMarks("chemistry", 0) });
            bool eligible = factors[0] >= 65 && factors[1] >= 55 && factors[2] >= 50 && (factors.Sum() >= 180 || factors[0] + factors[1] >=140);
            Console.WriteLine("\nYou are {0}eligible for admission", eligible ? "" : "not ");
            ReadKeyAndClear();
        }

        private static double GetMarks(string subject, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.");
            Console.WriteLine("\nEnter your marks in {0}...\n", subject);
            double marks = 0;
            if (double.TryParse(Console.ReadLine(), out marks))
                return marks;
            return GetMarks(subject, ++attempts);
        }

        private static void ConditionalStatementExercise11()
        {
            Console.WriteLine("Input three numbers and I will use them to calculate the roots of a quadratic equation.");
            Dictionary<string, double> quadNums = new Dictionary<string, double>()
            {
                { "a", 0 },
                { "b", 0 },
                { "c", 0 }
            };
            string[] indexer = new string[3] { "a", "b", "c" };
            foreach (string index in indexer)
                quadNums[index] = (double)GetQuadNumber(index, 0);
            double rootA = GetRootOfQuadraticEquation(quadNums["a"], quadNums["b"], quadNums["c"], Operation.Addition);
            double rootB = GetRootOfQuadraticEquation(quadNums["a"], quadNums["b"], quadNums["c"], Operation.Subtraction);
            Console.WriteLine("\nThe roots of {0} are {1} and {2}", $"-{quadNums["b"]} \u00B1 \u221A" + $"({quadNums["b"]}\xB2 - 4({quadNums["a"]})(-{quadNums["c"]}))/(2({quadNums["a"]}))", rootA, rootB);
            bool userWantsToDoAnother = (bool)FindOutIfTheUserWantsToDoAnother(0);
            Console.Clear();
            if (userWantsToDoAnother)
                ConditionalStatementExercise11();
        }

        private static object GetQuadNumber(string varName, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try Again.");
            Console.WriteLine("\nEnter the value for variable {0}...\n", varName);
            double num = 0;
            if (double.TryParse(Console.ReadLine(), out num))
                return num;
            return GetQuadNumber(varName, ++attempts);
        }

        private enum Operation
        {
            Addition,
            Subtraction
        };

        private static double GetRootOfQuadraticEquation(double a, double b, double c, Operation op)
        {
            return op == Operation.Addition ?
                ((b > 0 ? b * -1 : b) + Math.Sqrt((b * b) - 4 * a * (c > 0 ? c * -1 : c))) / (2 * a) :
                ((b > 0 ? b * -1 : b) - Math.Sqrt((b * b) - 4 * a * (c > 0 ? c * -1 : c))) / (2 * a);
        }

        public static object FindOutIfTheUserWantsToDoAnother(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour response doesn't make any sense. Try again.");
            Console.WriteLine("\nYou would like to try with a different set of numbers? (y/n)\n");
            string response = Console.ReadLine().ToLower();
            if (Regex.IsMatch(response, @"\b(y|yes)\b"))
                return true;
            else if (Regex.IsMatch(response, @"\b(n|no)\b"))
                return false;
            return FindOutIfTheUserWantsToDoAnother(++attempts);
        }

        private static void ConditionalStatementExercise12()
        {
            string name = (string)GetStudentName(0);
            int rollNum = (int)GetStudentRollNumber(0);
            Dictionary<string, double> subjectMarks = new Dictionary<string, double>()
            {
                { "Physics", 0 },
                { "Chemistry", 0 },
                { "Computer Applications", 0 }
            };
            string[] indexer = new string[3] { "Physics", "Chemistry", "Computer Applications" };
            for (int i = 0; i < subjectMarks.Count; i++)
                subjectMarks[indexer[i]] = (double)GetSubjectMarks(indexer[i], 0);
            double marksTotal = subjectMarks.Sum(m => m.Value);
            double percentage = (marksTotal / subjectMarks.Count);
            string division = GetDivision(percentage);
            Console.WriteLine($"\nName of Student: {name}");
            Console.WriteLine($"Student Roll #: {rollNum}");
            foreach (KeyValuePair<string, double> subjectMark in subjectMarks)
                Console.WriteLine($"Marks in {subjectMark.Key}: {subjectMark.Value}");
            Console.WriteLine($"Total Marks: {marksTotal}");
            Console.WriteLine($"Percentage: {percentage}");
            Console.WriteLine($"Division: {division}");
            ReadKeyAndClear();
        }

        private static object GetStudentName(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.\n");
            Console.WriteLine("Enter the student's name...\n");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
                return response;
            return GetStudentName(++attempts);
        }

        private static object GetStudentRollNumber(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try Again.");
            Console.WriteLine("\nEnter the student's roll number...\n");
            int rollNum = 0;
            if (Int32.TryParse(Console.ReadLine(), out rollNum))
                return rollNum;
            return GetStudentRollNumber(++attempts);
        }

        private static object GetSubjectMarks(string subject, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.");
            Console.WriteLine($"\nEnter the student's marks for {subject}...\n");
            double marks = 0;
            if (double.TryParse(Console.ReadLine(), out marks))
                return marks;
            return GetSubjectMarks(subject, ++attempts);
        }

        private static string GetDivision(double percentage)
        {
            if (percentage >= 60)
                return "First";
            else if (percentage < 60 && percentage >= 48)
                return "Second";
            else if (percentage < 48 && percentage >= 36)
                return "Pass";
            else
                return "Fail";
        }

        private static void ConditionalStatementExercise13()
        {
            double temp = (double)GetTemperature(0);
            Console.WriteLine($"\nIt's {GetTemperatureMessage(temp)} weather");
            ReadKeyAndClear();
        }

        private static object GetTemperature(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.\n");
            Console.WriteLine("Enter the temperature in degrees farhenheit...\n");
            double temp = 0;
            if (double.TryParse(Console.ReadLine(), out temp))
                return temp;
            return GetTemperature(++attempts);
        }

        private static string GetTemperatureMessage(double temp)
        {
            if (temp < 32)
                return "freezing";
            else if (temp >= 32 && temp < 50)
                return "very cold";
            else if (temp >= 50 && temp < 68)
                return "cold";
            else if (temp >= 68 && temp < 86)
                return "normal";
            else if (temp >= 86 && temp < 104)
                return "hot";
            return "very hot";
        }

        private static void ConditionalStatementExercise14()
        {
            Console.WriteLine("Enter the length of each side of a triangle and I will tell you whether the triangle is iscosoles, equilateral or scalene");
            double[] sides = new double[3];
            for (int i = 0; i < sides.Length; i++)
                sides[i] = (double)GetSide((i + 1).Ordinal(), 0);
            int triangleType = GetTriangleType(sides);
            Console.WriteLine("\nYou've input the data of {0} {1} triangle", triangleType == (int)TriangleTypes.isosceles || triangleType == (int)TriangleTypes.equilateral ? "an" : "a", triangleTypes[triangleType]);
            ReadKeyAndClear();
        }

        private static object GetSide(string sideNum, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.");
            Console.WriteLine($"\nEnter the length of the {sideNum} side...\n");
            double side = 0;
            if (double.TryParse(Console.ReadLine(), out side))
                return side;
            return GetSide(sideNum, ++attempts);
        }

        private static int GetTriangleType(double[] sides)
        {
            Array.Sort(sides);
            if ((sides[0] == sides[1] && sides[1] != sides[2]) || (sides[0] != sides[1] && sides[1] == sides[2]))
                return (int)TriangleTypes.isosceles;
            if (sides[0] == sides[1] && sides[1] == sides[2])
                return (int)TriangleTypes.equilateral;
            return (int)TriangleTypes.scalene;
        }

        private static readonly string[] triangleTypes = { "isosceles", "equilateral", "scalene" };

        private enum TriangleTypes
        {
            isosceles,
            equilateral,
            scalene
        }

        private static void ConditionalStatementExercise15()
        {
            Console.WriteLine("Input the degrees of each angle to be included in a triangle and I will tell you if, with those angles, a triangle can be formed.");
            double[] angles = new double[3] { (double)GetAngle("first", 0), (double)GetAngle("second", 0), (double)GetAngle("third", 0) };
            bool validAngleSum = angles.Sum() == 180;
            Console.WriteLine("\nWith the angles entered, a triangle can{0} be formed", validAngleSum ? "" : "not");
            ReadKeyAndClear();
        }

        private static object GetAngle(string angleNum, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.");
            Console.WriteLine($"\nEnter a number for the {angleNum} angle...\n");
            double angle = 0;
            if (double.TryParse(Console.ReadLine(), out angle) && angle > 0 && angle < 180)
                return angle;
            return GetAngle(angleNum, ++attempts);
        }

        private static void ConditionalStatementExercise16()
        {
            char letter = (char)GetLetter(0);
            Console.WriteLine($"\nThe letter {letter} is a {Alphabet[letter]}");
            bool userWantsToDoAnotherLetter = (bool)FindOutIfTheUserWantsToDoAnotherLetter(0);
            Console.Clear();
            if (userWantsToDoAnotherLetter)
                ConditionalStatementExercise16();
        }

        private static object GetLetter(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYou input is invalid. Try again.\n");
            Console.WriteLine("Enter a letter and I will tell you if it is a vowel or a consonant...\n");
            char letter = new char();
            if (char.TryParse(Console.ReadLine().ToLower(), out letter) && Alphabet.Keys.Contains(letter))
                return letter;
            return GetLetter(++attempts);
        }

        private static readonly Dictionary<char, string> Alphabet = new Dictionary<char, string>()
        {
            { 'a', "vowel" },
            { 'b', "consonant" },
            { 'c', "consonant" },
            { 'd', "consonant" },
            { 'e', "vowel" },
            { 'f', "consonant" },
            { 'g', "consonant" },
            { 'h', "consonant" },
            { 'i', "vowel" },
            { 'j', "consonant" },
            { 'k', "consonant" },
            { 'l', "consonant" },
            { 'm', "consonant" },
            { 'n', "consonant" },
            { 'o', "vowel" },
            { 'p', "consonant" },
            { 'q', "consonant" },
            { 'r', "consonant" },
            { 's', "consonant" },
            { 't', "consonant" },
            { 'u', "vowel" },
            { 'v', "consonant" },
            { 'w', "consonant" },
            { 'x', "consonant" },
            { 'y', "vowel, sometimes" },
            { 'z', "consonant" }
        };

        private static object FindOutIfTheUserWantsToDoAnotherLetter(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour response didn't make sense. Try again");
            Console.WriteLine("\nWould you like to try another letter? (y/n)\n");
            string response = Console.ReadLine().ToLower();
            if (Regex.IsMatch(response, @"\b(y|yes)\b"))
                return true;
            else if (Regex.IsMatch(response, @"\b(n|no)\b"))
                return false;
            return FindOutIfTheUserWantsToDoAnotherLetter(++attempts);
        }

        private static void ConditionalStatementExercise17()
        {
            Console.WriteLine("Enter the cost incurred in obtaining/providing an item/service and the price paid by the customer and I will tell you the amount of loss or profit resulting from the transaction.");
            double cost = (double)GetAmount("cost incurred", 0);
            double charge = (double)GetAmount("price charged", 0);
            bool profit = cost < charge;
            Console.WriteLine("\nYou can book your {0} amount of ${1}", profit ? "profit" : "loss", charge - cost);
            ReadKeyAndClear();
        }

        private static object GetAmount(string type, int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again");
            Console.WriteLine($"\nEnter the {type} by you...\n");
            double amount = 0;
            if (double.TryParse(Console.ReadLine(), out amount))
                return amount;
            return GetAmount(type, ++attempts);
        }

        private static void ConditionalStatementExercise18()
        {
            Console.WriteLine("Enter information about a customer and their electricity consumption to get their power bill.");
            ElectricityBill bill = new ElectricityBill((int)GetCustomerId(0), (string)GetCustomerName(0), (double)GetCustomerUsage(0));
            bill.Print();
            ReadKeyAndClear();
        }

        private class ElectricityBill
        {
            private int CustomerId;
            private string CustomerName;
            private double CustomerUsage;
            private double Rate;
            private double Charge;
            private double Surcharge;
            private double TotalCharge;

            public ElectricityBill(int id, string name, double usage)
            {
                this.CustomerId = id;
                this.CustomerName = name;
                this.CustomerUsage = usage;
                this.Rate = GetRate();
                this.Charge = CalculateCharge();
                this.Surcharge = CalculateSurcharge();
                this.TotalCharge = CalculateTotal();
            }

            private double GetRate() =>
                CustomerUsage < 200 ? 1.2 : CustomerUsage < 400 ? 1.5 : CustomerUsage < 600 ? 1.8 : 2;

            private double CalculateCharge() =>
                CustomerUsage * Rate;

            private double CalculateSurcharge() =>
                Charge > 400 ? Charge * .15 : 0;

            private double CalculateTotal() =>
                Charge + Surcharge;

            internal void Print() =>
                Console.WriteLine($"\nCustomer ID: {CustomerId}\n" + 
                                  $"Customer Name: {CustomerName}\n" +
                                  $"Customer Usage: {CustomerUsage}\n" + 
                                  $"Charges @ ${Rate:0.00}/unit: ${Charge:0.00}\n" + 
                                  $"Surcharge: ${Surcharge:0.00}\n" + 
                                  $"Total: ${TotalCharge:0.00}");
        }

        private static object GetCustomerId(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.");
            Console.WriteLine("\nEnter the customer's ID number...\n");
            int id = 0;
            if (Int32.TryParse(Console.ReadLine(), out id))
                return id;
            return GetCustomerId(++attempts);
        }

        private static object GetCustomerName(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input it invalid. Try again.");
            Console.WriteLine("\nEnter the customer's name...\n");
            string name = Console.ReadLine();
            if (Regex.IsMatch(name, @"([A-Z])\w+"))
                return name;
            return GetCustomerName(++attempts);
        }

        private static object GetCustomerUsage(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.");
            Console.WriteLine("\nEnter the customer's electricity usage...\n");
            double usage = 0;
            if (double.TryParse(Console.ReadLine(), out usage))
                return usage;
            return GetCustomerUsage(++attempts);
        }

        private static void ConditionalStatementExercise19()
        {
            char grade = (char)GetLetterGrade(0);
            Console.WriteLine($"\nLetter Grade: {grade}\nDescription: {gradeDescriptions[grade]}");
            ReadKeyAndClear();
        }

        private static object GetLetterGrade(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.\n");
            Console.WriteLine("Enter a letter grade (E, V, G, A, F) to get it's description...\n");
            char grade = new char();
            if (char.TryParse(Console.ReadLine().ToUpper(), out grade) && gradeDescriptions.Keys.Contains(grade))
                return grade;
            return GetLetterGrade(++attempts);
        }

        private static readonly Dictionary<char, string> gradeDescriptions = new Dictionary<char, string>()
        {
            { 'E', "Excellent" },
            { 'V', "Very Good" },
            { 'G', "Good" },
            { 'A', "Average" },
            { 'F', "Fail" }
        };

        private static void ConditionalStatementExercise20()
        {
            Console.WriteLine(new DayOfTheWeek().Message);
            ReadKeyAndClear();
        }

        private class DayOfTheWeek
        {
            public DayOfTheWeek()
            {
                DayNumber = (int)GetDayNumber(0);
                DayName = DaysOfTheWeek[DayNumber];
                Message = $"\nThe name of the day of the week that corresponds to the number enter is: {DayName}";
            }

            public int DayNumber;
            public string DayName;
            public string Message;

            private static readonly Dictionary<int, string> DaysOfTheWeek = new Dictionary<int, string>()
            {
                { 1, "Monday" },
                { 2, "Tuesday" },
                { 3, "Wednesday" },
                { 4, "Thursday" },
                { 5, "Friday" },
                { 6, "Saturday" },
                { 7, "Sunday" }
            };

            private static object GetDayNumber(int attempts)
            {
                if (attempts > 0)
                    Console.WriteLine("\nYour input is invalid. Try again.\n");
                Console.WriteLine("Enter a positive whole number from 1 to 7 to get the day of the week that is represented by that number...\n");
                int dayNum = 0;
                if (Int32.TryParse(Console.ReadLine(), out dayNum) && DaysOfTheWeek.Keys.Contains(dayNum))
                    return dayNum;
                return GetDayNumber(++attempts);
            }
        }

        private static void ConditionalStatementExercise21()
        {
            Console.WriteLine(new SingleDigit().Message);
            ReadKeyAndClear();
        }

        private class SingleDigit
        {
            public SingleDigit()
            {
                Digit = (int)GetNumber(0);
                NumberWord = NumberWords[Digit];
                Message = $"\nThe worded version of the number you entered, {Digit}, is: {NumberWord}";
            }

            private int Digit;
            private string NumberWord;
            public string Message;

            private static readonly Dictionary<int, string> NumberWords = new Dictionary<int, string>()
            {
                { 0, "Zero" },
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" },
                { 4, "Four" },
                { 5, "Five" },
                { 6, "Six" },
                { 7, "Seven" },
                { 8, "Eight" },
                { 9, "Nine" }
            };

            private static object GetNumber(int attempts)
            {
                if (attempts > 0)
                    Console.WriteLine("\nYour input is invalid. Try again.\n");
                Console.WriteLine("Enter a single digit and I will give you the worded number...\n");
                int digit = 0;
                if (Int32.TryParse(Console.ReadLine(), out digit) && NumberWords.Keys.Contains(digit))
                    return digit;
                return GetNumber(++attempts);
            }
        }

        private static void ConditionalStatementExercise22()
        {
            Console.WriteLine(new Month().Message);
            ReadKeyAndClear();
        }

        private class Month
        {
            public Month()
            {
                MonthNumber = (int)GetMonthNumber(0);
                MonthName = Months[MonthNumber];
                Message = $"\nThe name of the month is: {MonthName}";
            }

            private static int MonthNumber;
            private static string MonthName;
            public string Message;

            private static readonly Dictionary<int, string> Months = new Dictionary<int, string>()
            {
                { 1, "January" },
                { 2, "February" },
                { 3, "March" },
                { 4, "April" },
                { 5, "May" },
                { 6, "June" },
                { 7, "July" },
                { 8, "August" },
                { 9, "September" },
                { 10, "October" },
                { 11, "November" },
                { 12, "December" }
            };

            private static object GetMonthNumber(int attempts)
            {
                if (attempts > 0)
                    Console.WriteLine("\nYour input is invalid. Try again.\n");
                Console.WriteLine("Input a month number and I will tell you the name of the month...\n");
                int monthNum = 0;
                if (Int32.TryParse(Console.ReadLine(), out monthNum) && Months.Keys.Contains(monthNum))
                    return monthNum;
                return GetMonthNumber(++attempts);
            }
        }

        private static void ConditionalStatementExercise23()
        {
            OrderedDictionary months = new OrderedDictionary()
            {
                { "January", 31 },
                { "February", 28 },
                { "March", 31 },
                { "April", 30 },
                { "May", 31 },
                { "June", 30 },
                { "July", 31 },
                { "August", 31 },
                { "September", 30 },
                { "October", 31 },
                { "November", 30 },
                { "December", 31 }
            };
            int monthNum = (int)GetMonthNumber(0);
            DictionaryEntry monthData = months.Cast<DictionaryEntry>().ElementAt(monthNum - 1);
            Console.WriteLine($"\n{monthData.Key} has {monthData.Value} days");
            ReadKeyAndClear();
        }

        private static object GetMonthNumber(int attempts)
        {
            if (attempts > 0)
                Console.WriteLine("\nYour input is invalid. Try again.\n");
            Console.WriteLine("Enter the month number and I will tell you how many days that month has...\n");
            int monthNum = 0;
            if (Int32.TryParse(Console.ReadLine(), out monthNum) && monthNum > 0 && monthNum < 13)
                return monthNum;
            return GetMonthNumber(++attempts);
        }

        private static void ConditionalStatementExercise24() =>
            ExerciseNotComplete();

        private static void ConditionalStatementExercise25() =>
            ExerciseNotComplete();

        private static void ExerciseNotComplete()
        {
            Console.WriteLine("This exercise has not been completed yet, but thanks for dropping by!");
            ReadKeyAndClear();
        }
    }
}
