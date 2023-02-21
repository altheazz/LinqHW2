using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW2_1
{
    internal class Program
    {
        static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));
        static void ChangeArray(string[] arr) => Array.Reverse(arr);
        static void Main(string[] args)
        {
            //string[] num = new string[10];
            Console.WriteLine("輸入數字列，並用逗號隔開");
            //for(int i = 0; i< 5;i++)
            //{
            //    string x = Convert.ToString(Console.ReadLine());
            //    num[i] = x;
            //}

            string x = Convert.ToString(Console.ReadLine());

            string[] x_result = x.Split(',');



            ChangeArray(x_result);
            Console.WriteLine("倒序");
            DisplayArray(x_result);
            Console.WriteLine();

        }
    }
}
