using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Class8
    {
        //maximum and minimum element in an array
        public void MaxOfElements()
        {
            int i, max, n;
            Console.WriteLine("Number of elements in an array:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] intArray= new int[n]; 
            
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = intArray[0];
           
            for (i=0;i<n;i++)
            {
                if(intArray[i] > max)
                {
                    max = intArray[i];
                }
            }
            Console.WriteLine("Max number in array is: {0}", max);
            Console.ReadKey();
        }

        public void MinOfElements()
        {
            int[] intArray = new int[6];
            int i, min, n;

            Console.WriteLine("Number of elements in an array:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            min = intArray[0];

            for (i = 0; i < n; i++)
            {
                if (intArray[i] < min)
                {
                    min = intArray[i];
                }
            }
            Console.WriteLine("Min number in array is: {0}", min);
            Console.ReadKey();
        }

    }
}
