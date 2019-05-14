using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Class3
    {
        //Display the pattern like right angle triangle
        public void PrintPattern()
        {
            string numberofrows;
            int a;

            //take input from user
            Console.WriteLine("Enter the number of rows for printing the pattern");
            numberofrows = Console.ReadLine();

            a = Convert.ToInt32(numberofrows);
            Console.WriteLine("You entered: {0} ", a);

            int i, j, k;
            for (i = 1; i <= a; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
