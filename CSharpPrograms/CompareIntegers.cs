using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramAssignments
{
    public class CompareIntegers
    {

        public  static void cmp()
        {

            Console.WriteLine("Enter Numbers:");
            String ss = Console.ReadLine();
            String ss1 = Console.ReadLine();

            bool success = int.TryParse(ss, out int num1);

            bool success1 = int.TryParse(ss1, out int num2);


            if (success == true && success1 == true)
            {

                Console.WriteLine("After Comparing Result is: ");
                Console.WriteLine(((num1 > 0 && num2 < 0) || (num1 < 0 && num2 > 0)) ? "true" : "false");
            }



            else
            {
                Console.WriteLine("Invalid Integers");
            }



            Console.ReadLine();

        }

        


           


    }
}
