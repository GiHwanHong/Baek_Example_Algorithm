using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number2742
{
    /// <summary>
    /// 백준 온라인 저지
    ///   link : https://www.acmicpc.net/problem/2742
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = a; i >= 1; i--)
            {
                sb.AppendLine(i.ToString());
            }
            Console.Write(sb.ToString());
        }
    }
}
