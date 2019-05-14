using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Class6
    {
        public void StringArray()
        {
           string[] str2 = new string[]{"Element1","Element2","Element3","Element4","Element5"};
           Console.Write("Enter the string to search: ");
            string strToCheck = Console.ReadLine();
            int pos = Array.IndexOf(str2, strToCheck);
            
            foreach (string item in str2)
            {
                if (item.Equals(strToCheck))
                {
                    Console.Write("Element present in the string!");
                    Console.WriteLine("\nIndex of Element is: {0}",Array.IndexOf(str2, item));
                }
            }
            
            Console.ReadKey();
        }
    }
}
