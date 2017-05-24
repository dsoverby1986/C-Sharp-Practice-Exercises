using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice_Exercises.Extensions
{
    public static class DoubleExtensions
    {
        public static double Round(this double num, int decPlaces) =>
            Math.Round(num, decPlaces);
    }
}
