using Assignment;
using ProgramAssignments;
using System;

namespace CSharpPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String UserChoice = string.Empty;
            do
            {

                int print;
                Console.WriteLine("Enter Option\n 1: Swapping Two Numbers \n 2:Add Sub Multiply Divide Two Numbers  \n 3:Print multiplication Table \n 4:To Check whether Two Integers are Positive or Negative \n 5:Print a Pattern \n 6:Sum of Elements Stored in Array");
                print = int.Parse(Console.ReadLine());
                switch (print)
                {
                    case 1:
                        swappingnumbers ss = new swappingnumbers();
                        ss.Swapnos();
                        break;
                    case 2:
                        Calculation cc = new Calculation();
                        cc.Calc();
                        break;
                    case 3:
                        MultiplicationTable mt = new MultiplicationTable();
                        mt.Table();
                        break;
                    case 4:
                        CompareIntegers.cmp();

                        break;
                    case 5:
                        PrintPattern.Pattern();
                        break;
                    case 6:
                        PrintSum.sum();
                        break;
                    default:
                        Console.WriteLine("Invalid Option {0}", print);
                        break;

                }
                do
                {
                    Console.WriteLine("Do you want to continue-Yes or No");
                    UserChoice = Console.ReadLine();
                    if (UserChoice != "Yes" && UserChoice != "No")
                    {
                        Console.WriteLine("Invalid Choice,please say Yes or No");

                    }


                }
                while (UserChoice != "Yes" && UserChoice != "No");
            }



            while (UserChoice == "Yes");
        }

    }
}

