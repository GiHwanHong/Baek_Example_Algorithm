using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number8393
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            int res = 0;
            for (int i = 1;i<=number; i++)
            {
                res += i ;
            }
            Console.WriteLine(res);
        }
    }
}
