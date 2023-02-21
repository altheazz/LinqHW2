using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入數字列，並用逗號隔開");
            //string x = Convert.ToString(Console.ReadLine());
            string[] x_result = Console.ReadLine().Split(',');

            var odd = x_result.Where((x) => int.Parse(x) % 2 != 0);//奇
            var even = x_result.Where((x) => int.Parse(x) % 2 == 0);//偶

            Console.WriteLine($"奇數：{string.Join(",",odd)}");
            Console.WriteLine($"偶數：{string.Join(",", even)}");
        }
    }
}
