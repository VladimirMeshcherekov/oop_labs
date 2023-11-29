using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
   /// <summary>
   /// Содержит методы для работы с матрицами 3х3
   /// </summary>
    public class MatrixCalc : IMatrixCalc
    {
        /// <summary>
        /// Сложение 2х матриц 3х3
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static int[,] SumTwoMatrices(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
        
        /// <summary>
        /// Умножение 2х матриц 3х3
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static int[,] MultiplyTwoMatrices(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }
        
        /// <summary>
        /// Умножение матрицы на число (number)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int[,] MultiplyMatrixByNumber(int[,] matrix, int number)
        {
            int[,] result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = matrix[i, j] * number;
                }
            }

            return result;
        }
        
    }
}
