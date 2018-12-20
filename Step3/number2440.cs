using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number2440
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int N = Int32.Parse(Console.ReadLine());


            for (i = 0; i < N; i++)
            {
                for ( j = N; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
