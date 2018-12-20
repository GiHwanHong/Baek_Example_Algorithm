using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number2439
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int N = Int32.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {
                for(j = 0; j < N-i-1; j++)
                {
                    Console.Write(' ');
                }
                for (j = 0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
