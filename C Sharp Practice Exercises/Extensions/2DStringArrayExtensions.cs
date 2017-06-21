using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice_Exercises.Extensions
{
    static class _2DStringArrayExtensions
    {
        public static int GetLongestStringLength(this string[,] _2dArray)
        {
            int length = 0;
            for(int i = 0; i < _2dArray.GetLength(0); i++)
            {
                string[] array = _2dArray.GetRow(i);
                Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
                if (array[array.Length - 1].Length > length)
                    length = array[array.Length - 1].Length;
            }

            return length;
        }
    }
}
