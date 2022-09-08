using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramAssignments
{
    public class PrintPattern
    {

        public static void Pattern()
        {
            int val ;
            int i, j, k;
            Console.WriteLine("Enter the Number");
            val = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    // Console.Write(" ");  
                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write(val);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }


    }
}
