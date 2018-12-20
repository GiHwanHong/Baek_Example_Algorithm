using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number11720
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var str = Console.ReadLine();   // 갯수
            int number=int.Parse(str);
            str = Console.ReadLine();
            int res = 0;

            for (int i = 0; i < number; i++)
            {
                res += Convert.ToInt32(str[i].ToString());
            }
            Console.WriteLine(res);
        }
    }
}
