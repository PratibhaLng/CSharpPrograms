using System;

namespace ProgramAssignments

{
    public class swappingnumbers
    { 
       public  void Swapnos()
        {

            int num1, num2, temp;
            
            num1 = GetNum1();

            num2 = GetNum2();

            Console.WriteLine("Before Swapping First number ={0} Second number={1}", num1, num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping First number ={0} Second number={1}", num1, num2);

            Console.ReadKey();

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
