using System;

namespace learn
{
    class Program
    {


        static void Main()
        {
            MatrixTools m = new MatrixTools();
            int[,] matrix = new int[10, 10];
            m.Fill1(matrix);
            m.Print(matrix);
        }      
    }
}
