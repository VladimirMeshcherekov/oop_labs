using System;
using lab4;

namespace LabLibraryTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            int[,] matrix1 = 
          {
              {1, 2, 3},
              {4, 5, 6},
              {7, 8, 9}
          };
          
          int[,] matrix2 =
          {
              {9, 8, 7},
              {6, 5, 4},
              {3, 2, 1}
          };
         
          int[,] result0 = MatrixCalc.MultiplyMatrixByNumber(matrix1, 2);
          int[,] result1 = MatrixCalc.MultiplyTwoMatrices(matrix1, matrix2);
          int[,] result2 = MatrixCalc.SumTwoMatrices(matrix1, matrix2);
          Console.WriteLine(result0[0, 1]);
          Console.WriteLine(result1[0, 1]);
          Console.WriteLine(result2[0, 1]);
          
        }
    }
}
