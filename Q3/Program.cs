using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    /* 有一個數值,是四位數
     * 左邊二位的數字相同
     * 右邊二位的數字相同
     * 這個四位數值, 剛好也是某整數的平方
     * 請問這個四位數值是什麼?*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string fourNumber = String.Empty;
            int number = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    fourNumber = $"{i}{i}{k}{k}"; //四個數字以字串呈現
                    number = Convert.ToInt32(fourNumber); //將字串轉換成數值
                    string sqrtNumber = $"{Math.Sqrt(number)}"; //將數值開根號以字串形式呈現
                    //判斷開根號後的數值是否為整數
                    bool isInt = int.TryParse(sqrtNumber, out int sqrtNumber2);

                    if (isInt == true)
                    {
                        Console.WriteLine($"這個四位數值是 {fourNumber}");
                        return;
                    }
                }
            }
            
        }
    }
}
