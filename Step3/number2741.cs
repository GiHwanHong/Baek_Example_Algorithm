using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number2741
{
    /// <summary>
    /// 백준 온라인 저지
    ///   link : https://www.acmicpc.net/problem/2741
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= a; i++)
            {
                sb.AppendLine(i.ToString());
            }
            Console.Write(sb.ToString());
        }
    }
}
