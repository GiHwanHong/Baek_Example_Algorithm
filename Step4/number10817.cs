using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number10817
{
    class Program
    {
        /// <summary>
        ///  백준 온라인 저지 
        ///    link = https://www.acmicpc.net/problem/10817
        /// </summary>
        
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            

            int number1 = Int32.Parse(str[0]);
            int number2 = Int32.Parse(str[1]);
            int number3 = Int32.Parse(str[2]);
            int temp = 0;

            if (number1 > number2) { }
            else
            {
                temp = number1;
                number1 = number2;
                number2 = temp;
            }
            if(number1 > number3) { }
            else
            {
                temp = number1;
                number1 = number3;
                number3 = temp;
            }
            if(number2 > number3) { }
            else
            {
                temp = number2;
                number2 = number3;
                number3 = temp;
            }

            Console.WriteLine(number2);
                


        }
    }
}
