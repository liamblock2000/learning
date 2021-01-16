using System;
using System.Collections.Generic;
using System.Text;

namespace learn
{
    class ArrayTools
    {



        public void FillArray1(int[] arr)
        {
            // array.Length
            // fill this array with 1..1000
            //[1,2,3,4,5,6,7,8,..,1000]

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = i;
            }


        }

        public void FillArray2(int[] arr)
        {
            // fill this array with 1000...1
            //[1000,999,998....1]
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 999 - i;

            }
        }


        public void FillArray3(int[] arr)
        {
            // fill this array with 0,1,2,4,8...2000
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 2;

            }
        }


        public void Fill4(float[] arr)
        {
            // fill this array with 1,1,2,3,5,8,13,21,34,55...
            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];


            }
        }
        public void Print(float[] array)
        {
            // use a look to create this output to the console
            // whith array [1,2,3,4,5,6,7] print out to the screen [1,2,3,4,5,6]
            
            for(...)
            {

            }
            Console.Write("[");
            Console.Write($"{array[0]}");
            Console.Write($"{array[1]}");
            Console.WriteLine($"{array[2]}");
            Console.WriteLine($"{array[3]}");

            // Print the array
        }

    }
}
