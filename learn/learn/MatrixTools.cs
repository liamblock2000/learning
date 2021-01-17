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
           
            Console.Write("[");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 10; j++)
                {

                    Console.Write(",\t");
                    Console.Write(matrix[i,j]);

                }
            
            }
            Console.Write("]");
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

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)

                {
                    arr[i, j] = i + j;
                }



            }
        }




    }
}
