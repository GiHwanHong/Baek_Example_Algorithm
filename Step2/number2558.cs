using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number2558
{
    class Program
    {
        /// <summary>
        /// 백준 온라인 저지.
        /// link : https://www.acmicpc.net/problem/2558
        /// 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
        /// </summary>
        
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int number1 = Int32.Parse(str1);
            int number2 = Int32.Parse(str2);
            Console.WriteLine(number1 + number2);
        }
    }
}
