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
                int cal, sub, div, mul;




                Console.WriteLine("Enter Numbers:");
                String ss = Console.ReadLine();
                String ss1 = Console.ReadLine();

                bool success = int.TryParse(ss, out int num1);

                bool success1 = int.TryParse(ss1, out int num2);


                if (success == true && success1 == true)
                {



                    cal = num1 + num2;


                    sub = num1 - num2;


                    div = num1 / num2;

                    mul = num1 * num2;


                    Console.WriteLine("Subtraction of  Numbers is {0} \ndivision of  Numbers is {1} \nMultiplication of  Numbers is {2} \nSum of  Numbers is {3}", sub, div, mul, cal);
                }
                else

                               {
                    Console.WriteLine("Invalid Numbers"); }

                Console.ReadLine();

            }

            catch (Exception ex)

            {
                Console.WriteLine("Error:"+ex.Message);
            }

        }

       
       








    }
}
