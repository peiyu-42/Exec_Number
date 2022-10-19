using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        /*百元買百雞
         * 想用一百元買剛好一百隻雞, 公雞 5 元, 母雞 3 元, 小雞三隻 1 元
         * 字彙表:
         * 公雞(Cock), 母雞(Hen), 小雞(Chicken)*/
        static void Main(string[] args)
        {
            int cock, hen, chicken;
            
            double money;
            /*  cock + hen + chicken =100
             *  5*cock + 3*hen + chicken/3 =100
            */
            for (cock = 0; cock < 20; cock++) //公雞大於20隻超過預算
            {
                for (hen = 0; hen < 33; hen++)//母雞大於33隻超過預算
                {
                    chicken = 100 - cock - hen;
                    money = 5d * cock + 3d * hen + chicken / 3d; //計算出的money為double
                    string stringMoney = Convert.ToString(money);
                    bool isInt = int.TryParse(stringMoney, out int money2);
                    // money不能為double
                    if (isInt == false)
                    {
                        continue;
                    }

                    if (money == 100)
                    {
                        Console.WriteLine($"公雞: {cock}隻\r\n母雞: {hen}隻\r\n小雞: {chicken}隻");
                        Console.WriteLine();
                    }

                }
            }            
        }
    }
}
