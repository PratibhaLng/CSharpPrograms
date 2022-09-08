using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramAssignments
{
    public class CompareIntegers
    {

        public  static void cmp()
        {

            int num1, num2;
            Console.WriteLine("Enter the First number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(((num1 > 0 && num2 < 0) || (num1 < 0 && num2 > 0)) ? "true" : "false");
            Console.ReadLine();


        }




    }
}
