using System;
using Matrices.Models;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = {
                {   1, 2, 4, 5  },
                {   2, 5, 22, 3  },
                {   3, 2, 8, 6  },
                {   4, 0, 3, 9  },
            };

            int[,] matrixB = {
                {   1, 2, 4, 5  },
                {   2, 5, 22, 3  },
                {   3, 2, 8, 6  },
                {   4, 0, 3, 9  },
            };

            var matrix = new Matrix();
            
            //matrix.Determinant(matrixA);
            Matrix.Multiply(matrixA, matrixB);
        }
    }
}
