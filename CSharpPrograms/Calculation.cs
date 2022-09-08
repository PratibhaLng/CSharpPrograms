using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramAssignments

{
    public class Calculation
    {
        public void Calc()
        {

            try
            {
                int num1, num2, cal, sub, div, mul;



                
                num1 = GetNum1();
                
                num2 = GetNum2();



                cal = num1 + num2;


                sub = num1 - num2;


                div = num1 / num2;

                mul = num1 * num2;


                Console.WriteLine("Subtraction of  Numbers is {0} \ndivision of  Numbers is {1} \nMultiplication of  Numbers is {2} \nSum of  Numbers is {3}", sub, div, mul, cal);


                Console.ReadLine();

            }

            catch (Exception ex)

            {
                Console.WriteLine("Error:"+ex.Message);
            }

        }

        public int GetNum1()
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

        public int GetNum2()
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
