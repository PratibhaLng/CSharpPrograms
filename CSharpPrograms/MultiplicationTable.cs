using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ProgramAssignments
{
    public class MultiplicationTable
    {
        public  void Table()
        {

            Console.WriteLine("Enter a Number");
            String ss= Console.ReadLine(); ;

            int number, i;
            if (int.TryParse(ss, out number))
            {
                for (i = 1; i <= 10; i++)
                {
                    Console.Write("{0} x {1} = {2} \n", number, i, (number * i));

                }

            }
            else
            {
                Console.WriteLine("Invalid Number Entered");
            }

            Console.ReadKey();



        }

        
        

    }
}
