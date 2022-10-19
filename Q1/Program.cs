using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{//判斷某數值是不是質數
    internal class Program
    {
        static void Main(string[] args)
        {
            //輸入一個數字            
            Console.Write("請輸入一個數字，判斷是否為質數: ");
            string input = Console.ReadLine();

            //pre condition，input是不是空字串
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("您沒有輸入數字");
                return;
            }

            //若能解析成功，傳回true，number裡會有值；若解析失敗，傳回false，number =0
            bool isInt = int.TryParse(input, out int number);

            // pre condition，input是不是數字。是否有十個數字，開頭是否為09
            if (isInt == false || number <= 1)            
            {
                Console.WriteLine("請輸入大於1的正整數");
                return;
            }

            //迴圈數為數值的開根號
            int length = (int)Math.Sqrt(number);
            for (int i = 2; i <= length; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{number} 不是質數");
                    return;
                }
            }
            Console.WriteLine($"{number} 是質數");
        }
    }
}
