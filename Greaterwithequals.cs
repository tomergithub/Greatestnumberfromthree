using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_pracGreatestnumberfromthree
{   
    class Greaterwithequals
    {
        public void Greatestwithequals1()
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Enter num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num3:");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("num1 is greatest");
                }
                else if (num1 == num3)
                {
                    Console.WriteLine("num 1 and num3 both greatest");
                }
                else Console.WriteLine("num3 is greatest");
            }
            else if (num1 == num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("num1 and num2 both are greatest");
                }
                else
                {
                    Console.WriteLine("num3 is greatest");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("num2 is greatest");
            }
            else
            {
                Console.WriteLine("num3 is greatest");
            }
        }
        static void Main(string[] args)
        {
            Greaterwithequals cal1 = new Greaterwithequals();

            cal1.Greatestwithequals1();
            Console.ReadKey();
        }
    }
}
