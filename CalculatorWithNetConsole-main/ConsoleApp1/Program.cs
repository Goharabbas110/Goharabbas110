using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string choice;
            arithmeticclass obj = new arithmeticclass();
            do {
            start:
                Console.Write("Please Provide 1st Number : ");
                try
                {
                    obj.a = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message.ToString());
                    goto start;
                }
            repeat:
                Console.Write("Please Provide 2nd Number : ");
                try
                {
                    obj.b = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message.ToString());
                    goto repeat;
                }
                Console.Write("1 : For ADD\n2 : For Subtract\n3 : FOr Divide\n4 : For multiply\nPlease Provide OPtion to proceed : ");

                String inputs = Console.ReadLine();
                if (inputs == "1")
                {
                    Console.WriteLine("Your Ans Is : " + obj.GetSum());
                }
                else if (inputs == "2")
                {
                    Console.WriteLine("Your Ans Is : " + obj.GetSubtract());
                }
                else if (inputs == "3")
                {
                    Console.WriteLine("Your Ans Is : " + obj.GetDivide());
                }
                else if (inputs == "4")
                {
                    Console.WriteLine("Your Ans Is : " + obj.GetMultilply());
                }
                else
                {
                    Console.Write("You Eneterd invalid OPtion. Press ANy Key to close");
                }
                Console.Write("Press Y or y to continue : ");
                choice = Console.ReadLine();
            }
            while (choice == "Y" || choice == "y" );
        }
    }

    public class arithmeticclass
    {
        public int a, b;

        public int GetSum()
        {
            return a + b;
        }
        public int GetSubtract()
        {
            return a - b;
        }
        public int GetDivide()
        {
            return a / b;
        }
        public int GetMultilply()
        {
            return a * b;
        }
    }
}