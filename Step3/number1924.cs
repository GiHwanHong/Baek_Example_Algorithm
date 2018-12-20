using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number1924
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] month_days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] days = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };

            string day = Console.ReadLine();
            string[] monthAndday = day.Split();
            int res = Int32.Parse(monthAndday[1]);

            for (int i = 1; i < Int32.Parse(monthAndday[0]); i++)
            {
                res += month_days[i - 1];
            }
            int add = res % 7;
            Console.WriteLine(days[add]);

        }
    }
}
