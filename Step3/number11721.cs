using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number11721
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
                if ((i+1) % 10 ==0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
