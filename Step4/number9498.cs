using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number9498
{
    class Program
    {
        /// <summary>
        /// 백준 온라인 저지
        ///   link = https://www.acmicpc.net/problem/9498
        /// </summary>
        
        static void Main(string[] args)
        {
            int score = Int32.Parse(Console.ReadLine());

            if(score >=90)
                Console.WriteLine("A");
            else if(score >=80 && score <90)
                Console.WriteLine("B");
            else if(score >=70 && score <80)
                Console.WriteLine("C");
            else if(score >=60 && score <70)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
        }
    }
}
