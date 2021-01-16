using System;
using System.Collections.Generic;
using System.Text;

namespace learn
{
    class MatrixTools
    {
        public void Print(int[,] matrix)
        {
            // 1 ... 10
            // 11... 20
            //    ...
            // 91 ... 100
            for (int i=0; i< 10 ;i++)
            {
                for(int j=0; j< 10; j++)
                {
                    Console.Write(matrix[i,j]);
                }
            }
        }


        public void Fill1(int[,] matrix)
        {
            // 1 ... 10
            // 11... 20
            //    ...
            // 91 ... 100
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = i + j;
                }
            }
        }



    }
}
