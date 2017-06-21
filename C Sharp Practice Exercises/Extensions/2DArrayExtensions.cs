using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice_Exercises.Extensions
{
    static class _2DArrayExtensions
    {
        public static T[] GetRow<T>(this T[,] _2dArray, int row)
        {
            int cols = _2dArray.GetUpperBound(1) + 1;
            T[] array = new T[cols];
            for (int i = 0; i < _2dArray.GetLength(0); i++)
                if (i == row)
                    for (int j = 0; j < cols; j++)
                        array[j] = _2dArray[i, j];

            return array;
        }
    }
}