using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Class7
    {
        public void ReverseArray()
        {
            int[] arr = new int[] { 1,2,3,4,5,6,7,8,9};
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }

            Array.Reverse(arr);

            Console.WriteLine("Reversed Array : ");
            foreach (int value in arr)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
            
        }


    }
}

