using System;

namespace ProgramAssignments

{
    public class swappingnumbers
    { 
       public  void Swapnos()
        {

            int  temp;
            Console.WriteLine("Enter Numbers:");
            String ss = Console.ReadLine();
            String ss1 = Console.ReadLine();

            bool success = int.TryParse(ss, out int num1);

            bool success1 = int.TryParse(ss1, out int num2);


            if (success == true && success1 == true)
            {

                Console.WriteLine("Before Swapping First number ={0} Second number={1}", num1, num2);

                temp = num1;
                num1 = num2;
                num2 = temp;

                Console.WriteLine("After Swapping First number ={0} Second number={1}", num1, num2);
            }

            else
            {
                Console.WriteLine("Invalid Numbers");
            
            }

            Console.ReadKey();

        }
        

       

    }
    
}
