using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    class Matrix
    {
        int[,] array = new int[2, 2];

        public Matrix(int x0, int x1, int x2, int x3)
        {
            array[0, 0] = x0;
            array[0, 1] = x1;
            array[1, 0] = x2;
            array[1, 1] = x3;
        }

        private int MultiplySingleLine(int startIndex, ref Matrix rhs, int rhsStartIndex)
        {
            int result = 0;

            for (int i = 0; i < array.GetLength(startIndex); ++i)
            {
                result += array[startIndex, i] * rhs.array[i, rhsStartIndex];
            }

            return result;
        }

        public Matrix Multiply(ref Matrix rhs)
        {
            int x0 = MultiplySingleLine(0, ref rhs, 0);
            int x1 = MultiplySingleLine(0, ref rhs, 1);
            int x2 = MultiplySingleLine(1, ref rhs, 0);
            int x3 = MultiplySingleLine(1, ref rhs, 1);

            return new Matrix(x0, x1, x2, x3);
        }
    }
}
