using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices.Models
{
    public class Matrix
    {
        public void Determinant(int[,] matrixA)
        {
            int determinant = 0;

            for (int i = 0; i < matrixA.GetLength(1); i++)
            {
                int vector = matrixA[0, i];
                if (i == 0)
                {
                    determinant += vector * ((matrixA[1, 1] * ((matrixA[2, 2] * matrixA[3, 3]) - (matrixA[3, 2] * matrixA[2, 3])))
                        - (matrixA[1, 2] * ((matrixA[2, 1] * matrixA[3, 3]) - (matrixA[3, 1] * matrixA[2, 3])))
                        + (matrixA[1, 3] * ((matrixA[2, 1] * matrixA[3, 2]) - (matrixA[3, 1] * matrixA[2, 2])))
                    );
                }
                else if (i == 1)
                {
                    determinant += -vector * ((matrixA[1, 0] * ((matrixA[2, 2] * matrixA[3, 3]) - (matrixA[3, 2] * matrixA[2, 3])))
                        - (matrixA[1, 2] * ((matrixA[2, 0] * matrixA[3, 3]) - (matrixA[3, 0] * matrixA[2, 3])))
                        + (matrixA[1, 3] * ((matrixA[2, 0] * matrixA[3, 2]) - (matrixA[3, 0] * matrixA[2, 2])))
                    );
                }
                else if (i == 2)
                {
                    determinant += vector * ((matrixA[1, 0] * ((matrixA[2, 1] * matrixA[3, 3]) - (matrixA[3, 1] * matrixA[2, 3])))
                        - (matrixA[1, 1] * ((matrixA[2, 0] * matrixA[3, 3]) - (matrixA[3, 0] * matrixA[2, 3])))
                        + (matrixA[1, 3] * ((matrixA[2, 0] * matrixA[3, 1]) - (matrixA[3, 0] * matrixA[2, 1])))
                    );
                }
                else
                {
                    determinant += -vector * ((matrixA[1, 0] * ((matrixA[2, 1] * matrixA[3, 2]) - (matrixA[3, 1] * matrixA[2, 2])))
                        - (matrixA[1, 1] * ((matrixA[2, 0] * matrixA[3, 2]) - (matrixA[3, 0] * matrixA[2, 2])))
                        + (matrixA[1, 2] * ((matrixA[2, 0] * matrixA[3, 1]) - (matrixA[3, 0] * matrixA[2, 1])))
                    );
                }
            }

            Console.WriteLine(determinant);
        }

        public static double[,] Multiply(int[,] matrixOne, int[,] matrixTwo)
        {
            var matrixOneRows = matrixOne.GetLength(0);
            var matrixOneColumns = matrixOne.GetLength(1);
            var matrixTwoRows = matrixTwo.GetLength(0);
            var matrixTwoColumns = matrixTwo.GetLength(1);

            // checking if matrices can be multiplied
            if (matrixOneColumns != matrixTwoRows)
                Console.WriteLine("Columns of first matrix must be equal to rows of second matrix");

            double[,] product = new double[matrixOneRows, matrixTwoColumns];

            // looping through matrix 1 rows  
            for (int matrixOne_row = 0; matrixOne_row < matrixOneRows; matrixOne_row++)
            {
                // for each matrix 1 row, loop through matrix 2 columns  
                for (int matrixTwo_col = 0; matrixTwo_col < matrixTwoColumns; matrixTwo_col++)
                {
                    // loop through matrix 1 columns to calculate the dot product  
                    for (int matrixOne_col = 0; matrixOne_col < matrixOneColumns; matrixOne_col++)
                    {
                        product[matrixOne_row, matrixTwo_col] +=
                          matrixOne[matrixOne_row, matrixOne_col] *
                          matrixTwo[matrixOne_col, matrixTwo_col];
                    }
                }
            }

            // Loop to display formed product matrix
            for (int i = 0; i < product.GetLength(0); i++)
            {
                for (int j = 0; j < product.GetLength(1); j++)
                {
                    Console.Write(product[i, j] + " ");
                }
                Console.WriteLine();
            }

            return product;
        }
    }
}
