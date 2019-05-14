using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Class1
    {
        public void SumOfNumbers()
        {
            int a;
            int result = 0;
            
            //taking input in string form 
            Console.WriteLine("Please enter 10 numbers:");

            for (int i = 0; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);
                a = Convert.ToInt32(Console.ReadLine());
                result += a;
            }

            Console.WriteLine("Sum of 10 numbers entered is: {0}", result);
            Console.ReadKey();
        }

    }
}
