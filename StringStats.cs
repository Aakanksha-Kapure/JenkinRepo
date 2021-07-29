using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class StringStats
    {
        static void Main()
        {
            string abc;
            Console.WriteLine("Enter a string");
            abc = Console.ReadLine();
            int upper = 0;
            int lower = 0;
            int count = 0;
            for (int i = 0; i < abc.Length; i++)
            {
                char ch = abc[i];
                if (ch >= 'A' && ch <= 'Z')
                    upper++;
                else if (ch >= 'a' && ch <= 'z')
                    lower++;
                else if (ch >= '0' && ch <= '9')
                    count++;
            }
            Console.WriteLine("Upper case letters" + upper);
            Console.WriteLine("Lower case letters" + lower);
            Console.WriteLine("Total Count" + count);
        }
    }
}

