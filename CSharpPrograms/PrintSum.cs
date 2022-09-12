using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class PrintSum
    {

        public static void sum()
        {

            int i;
            int sum = 0;
            Console.WriteLine("Enter the Number of Elements in Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Elements in Array are:");


            for (i = 0; i < size; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (i = 0; i < size; i++)
            {

                sum = sum + arr[i];

            }

            Console.WriteLine("Sum of all elements stored in the array is : {0}\n\n", sum);


            Console.ReadKey();


        }
    }
}
