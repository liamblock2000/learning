using System;
using System.Collections.Generic;
using System.Text;
namespace learn
{
    class MatrixTools
    {
        public void Print(int[,] matrix)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" ");
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
        public void FillArray3(int[,] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                
                {
                    arr[i,j] = i + j; 
                }
            }
        }
        public void FillArray4(int[,] arr)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = (j+i)%2;
                }
            }
        }



        public void FillArray5(int[,] arr)
        {
            // 1 0 0 0
            // 0 1 0 0
            // 0 0 1 0
            // 0 0 0 1
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(i ==j )
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                    
                }
            }
        }

        public void FillArray6(int[,] arr)
        {
            // 0 0 0 1
            // 0 0 1 0
            // 0 1 0 0
            // 1 0 0 0
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = (i+j)== 9 ? 1 : 0;
                }
            }
        }

        public void FillArray7(int[,] arr)
        {
            // 1 1 1 1
            // 1 0 0 1
            // 1 0 0 1
            // 1 1 1 1
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || j == 9)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }
        }


        public void FillArray8(int[,] arr)
        {
            // 0 1 1 1
            // 1 0 1 1
            // 1 1 0 1
            // 1 1 1 0
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(i !=j )
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                    
                }
            }
        }



    }
}