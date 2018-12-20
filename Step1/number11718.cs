using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number11718
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[5];
            for (int i = 0; i < 5; i++)
            {
                str[i] = Console.ReadLine();
            }
            foreach (var aaa in str)
            {
                Console.WriteLine(aaa);
            }
        }
    }
}
