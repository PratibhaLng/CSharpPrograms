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
            int number, i;
           
            number = GetNumber();
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} x {1} = {2} \n", number, i, (number * i));

            }

            Console.ReadKey();
        }

        public int GetNumber()
        { 
        bool isNumberValid = false;
            int number=0 ;
            while (isNumberValid == false)
            {
                Console.WriteLine("Enter the Number");
                isNumberValid = int.TryParse(Console.ReadLine() ,out  number);
                if(isNumberValid == false)
                {
                    Console.WriteLine("Enter only Numbers");
                    Console.ReadKey();

                }


            }

            return number;
        
        }

    }
}
