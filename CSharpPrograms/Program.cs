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


                Console.WriteLine("Select Option\n 1: Swapping Two Numbers \n 2:Add Sub Multiply Divide Two Numbers  \n 3:Print multiplication Table \n 4:To Check whether Two Integers are Positive or Negative \n 5:Print a Pattern \n 6:Sum of Elements Stored in Array");
                String ss = Console.ReadLine();


                if (int.TryParse(ss, out int print))
                {

                    switch (print)
                    {
                        case 1:
                            swappingnumbers sn = new swappingnumbers();
                            sn.Swapnos();
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

                }
                else
                {
                    Console.WriteLine("Not A Valid Option......  ");
                }



                    do
                    {
                        Console.WriteLine("Do you want to continue-Yes or No");
                        UserChoice = Console.ReadLine().ToUpper();
                        if (UserChoice != "YES" && UserChoice != "NO")
                        {
                            Console.WriteLine("Invalid Choice,please say YES or NO");

                        }


                    }
                    while (UserChoice != "YES" && UserChoice != "NO");
                }



                while (UserChoice == "YES") ;
            



            

        }

    }    }


