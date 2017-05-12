using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Sharp_Practice_Exercises.Extensions
{
    static class CharExtensions
    {
        public static string GetAnalysis(this char character)
        {
            string _char = character.ToString();
            string charIs = "The character is ";
            if(Regex.IsMatch(_char, @"[a-z]"))
                if (Regex.IsMatch(_char, @"[aeiouy]+$"))
                    return charIs += "a lowercase vowel";
                else
                    return charIs += "a lowercase consonant";
            else if (Regex.IsMatch(_char, @"[A-Z]"))
                if (Regex.IsMatch(_char, @"[AEIOUY]+$"))
                    return charIs += "an uppercase vowel";
                else
                    return charIs += "an uppercase consonant";
            else if (Regex.IsMatch(_char.ToString(), @"[\d]+$"))
                return charIs += "a digit";
            return charIs += "a symbol";
        }
    }
}
