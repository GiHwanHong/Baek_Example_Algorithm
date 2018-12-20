using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number2739
{
    class Program
    {
        static void Main(string[] args)
        {
            int N=Int32.Parse(Console.ReadLine());

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",N,i+1,N*(i+1));
            }

        }
    }
}
