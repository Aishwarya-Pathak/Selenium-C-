using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Class4
    {
        //Display the first n terms of Fibonacci series
        public void Fibonacci()
        {
            string number;
            int num, num1 = 0, num2 = 1, num3;
            Console.WriteLine("enter number of elements:");
            number = Console.ReadLine();
            num = Convert.ToInt32(number);

            Console.WriteLine(num1 + "" + num2 + "");
            for (int i = 2; i < num; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3 + "");
                num1 = num2;
                num2 = num3;
            }
            Console.ReadKey();
        }
    }
}
