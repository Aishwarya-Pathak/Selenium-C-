using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Class5
    {
        public void Conversion()
        {
            int i,j,m,a;
            //2D array
            //taking number of elements from user
            Console.WriteLine("Number of rows in an array:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of columns in an array:");
            a = Convert.ToInt32(Console.ReadLine());

            //declare 2D array 
            int[,] TwoDimensionalArray = new int[m, a];
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < a; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    TwoDimensionalArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //print elements from array
            Console.Write("\nThe 2D array is : \n");
            for (i = 0; i < m; i++)
            {
                Console.Write("\n");
                for (j = 0; j < a; j++)
                    Console.Write("{0}\t", TwoDimensionalArray[i, j]);
            }
            Console.Write("\n\n");

            //converting to 1D array
            
            // declare 1D array
            int[] OneDimensionalArray = new int[m*a];

            //print the elements in the array
            int k = 0;
            
            for (i = 0; i < m; i++)
            {
                Console.Write("\n");
                for (j = 0; j < a; j++)
                {
                    OneDimensionalArray[k]=TwoDimensionalArray[i,j];
                    k++;
                }
            }

            Console.WriteLine("1D array is:");
            for(i=0;i<m*a;i++)
            {
                Console.Write("{0}", OneDimensionalArray[i]);
            }
            Console.Write("\n\n");
            Console.ReadKey();

        }
    }
}
