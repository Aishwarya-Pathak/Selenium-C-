using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Class2
    {
        //Traverse for loop from 1 to 7 and display each day name using if and switch
        
        public void Method1()
        {
            string day;
            Console.WriteLine("Enter the day:");
            day = Console.ReadLine();
            int a = Convert.ToInt32(day);
            for (int i = 1; i < a; i++)
            {
                if (a == 1)
                {
                    Console.WriteLine("Monday");
                }
                else if (a == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                else if (a == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                else if (a == 4)
                {
                    Console.WriteLine("Thursday");
                }
                else if (a == 5)
                {
                    Console.WriteLine("Friday");
                }
                else if (a == 6)
                {
                    Console.WriteLine("Saturday");
                }
                else if (a == 7)
                {
                    Console.WriteLine("Sunday");
                }
            }
            Console.ReadKey();
        }

        public void Method2()
        {
            string day;
            Console.WriteLine("Enter the day:");
            day = Console.ReadLine();
            int b = Convert.ToInt32(day);
            switch (b)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            Console.ReadKey();

        }

    }
}
