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
            
            num1 = GetNum1();
            
            num2 = GetNum2();

            Console.WriteLine(((num1 > 0 && num2 < 0) || (num1 < 0 && num2 > 0)) ? "true" : "false");
            Console.ReadLine();


        }

        public  static int GetNum1()
        {
            bool isNumberValid = false;
            int num1 = 0;
            while (isNumberValid == false)
            {
                Console.WriteLine("Enter the First Number");
                isNumberValid = int.TryParse(Console.ReadLine(), out num1);
                if (isNumberValid == false)
                {
                    Console.WriteLine("Enter only Numbers");
                    Console.ReadKey();

                }


            }

            return num1;

        }

        public static int GetNum2()
        {
            bool isNumberValid = false;
            int num2 = 0;
            while (isNumberValid == false)
            {
                Console.WriteLine("Enter the Second Number");
                isNumberValid = int.TryParse(Console.ReadLine(), out num2);
                if (isNumberValid == false)
                {
                    Console.WriteLine("Enter only Numbers");
                    Console.ReadKey();

                }


            }

            return num2;

        }



    }
}
