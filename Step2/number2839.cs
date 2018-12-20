using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number2839
{
    /// <summary>
    /// 백준 온라인 저지
    ///  link : https://www.acmicpc.net/problem/2839
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            int deliverySuger = Int32.Parse(Console.ReadLine());  // 설탕공장에서 배달해야하는 설탕의 양
            int basket5 = 5, basket3 = 3;                   // 5kg와 3kg의 설탕의 양을 담을 수 있는 봉지
            int basketCnt = 0;              // 봉지 몇개를 가져가면 되는지를 나타내는 수.

            while (true)
            {
                if (deliverySuger % basket5 == 0)       // 5kg 봉지로 나누기 위함.
                {
                    Console.WriteLine(deliverySuger / 5 + basketCnt);
                    break;
                }
                else if (deliverySuger <= 0)     
                {
                    Console.WriteLine("-1");
                    break;
                }
                deliverySuger -= basket3;
                basketCnt++;

            }
            
            //Console.WriteLine(basketCnt);
        }
    }
}
