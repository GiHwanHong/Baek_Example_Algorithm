using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number15552
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            // 연산할 개수 
            // 연산
            // 모아놓고 
            // 한번에 출력.

            int NumberCnt = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < NumberCnt; i++)
            {
                string str = Console.ReadLine();
                string[] s = str.Split();

                int calc = Int32.Parse(s[0]) + Int32.Parse(s[1]);
                sb.Append(calc + "\n");
            }
            Console.Write($"{sb}");

        }
    }
}
