using System;

namespace learn
{
    class Program
    {

        static void FillArray1(int[] arr)
        {
            // array.Length
            // fill this array with 1..1000
            //[1,2,3,4,5,6,7,8,..,1000]
          
            for (int i = 1; i < arr.Length; i++)
            { 
                arr[i] = i;
            }


        }

        static void FillArray2(int[] arr)
        {
            // fill this array with 1000...1
            //[1000,999,998....1]
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 999 - i; 
                
            }
        }


        static void FillArray3(int[] arr)
        {
            // fill this array with 0,1,2,4,8...2000
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 2;

            }
        }


        static void FillArray4(float[] arr)
        {
            // fill this array with 1,1,2,3,5,8,13,21,34,55...
            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
           

            }
        }


        static void ArrayPrint(int[] array)
        {
            // Print the array,
            string a = "Hello World.";
            Console.Write($"{a}");
            Console.Write($"{a}");
            Console.Write($"{a}");

            Console.WriteLine("Hello World!");
         
        }


        static void Main()
        {
            float[] arr = new float[100];
            decimal b = 3;
            decimal c = 2;
            decimal d = b/c;
            Console.WriteLine(d);
            // Printing stuff
            //Program.FillArray1(arr);
            //Program.ArrayPrint(arr);

            //Program.FillArray2(arr);
            Program.FillArray4(arr);
            //Program.ArrayPrint

        }      
    }
}
