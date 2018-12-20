using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number10430
{
    class Program
    {
        /// <summary>
        ///  백준 온라인 저지
        ///  (A+B)%C는 (A%C + B%C)%C 와 같을까?
        ///  (A×B)%C는(A%C × B%C)%C 와 같을까?
        ///  link :https://www.acmicpc.net/problem/10430
        ///  세 수 A, B, C가 주어졌을 때, 위의 네 가지 값을 구하는 프로그램을 작성하시오.
        /// </summary>

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] s = str.Split();
            int number1 = Int32.Parse(s[0]);
            int number2 = Int32.Parse(s[1]);
            int number3 = Int32.Parse(s[2]);

            Console.WriteLine((number1 + number2) % number3);   //  (A+B)%C
            Console.WriteLine((number1 % number3 + number2 % number3) % number3); // (A%C + B%C)%C
            Console.WriteLine((number1 * number2) % number3);  // (A×B)%C
            Console.WriteLine((number1 % number3 * number2 % number3) % number3); // (A%C × B%C)%C
        }
    }
}
