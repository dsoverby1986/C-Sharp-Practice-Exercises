using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice_Exercises
{
    public static class Consoleum
    {
        public static void WriteLineReadKey(string str, params string[] strings)
        {
            Console.WriteLine(str, strings);
            Console.ReadKey();
        }
    }
}
