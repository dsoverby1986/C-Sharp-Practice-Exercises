using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice_Exercises.Extensions
{
    public static class IntExtensions
    {
        /// <summary>
        /// Takes a character and returns a string made up of the character, having a Length value equal to the int value. e.g.: 3.Pad('r') returns "rrr"
        /// </summary>
        /// <param name="num"></param>
        /// <param name="padChar"></param>
        /// <returns><see cref="string"/></returns>
        public static string Pad(this int num, char padChar)
        {
            string padding = "";
            for (int i = 0; i < num; i++)
                padding += padChar;
            return padding;
        }

        /// <summary>
        /// Returns the ordinal value appropriate for the integer
        /// </summary>
        /// <param name="num"></param>
        /// <returns><see cref="string"/></returns>
        public static string Ordinal(this int num)
        {
            if (num <= 0) return num.ToString();

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }

            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }
        }
    }
}
