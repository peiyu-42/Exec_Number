using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{//找出數值區間內的所有質數
    internal class Program
    {
        static void Main(string[] args)
        {
            //數值區間
            int numberA = 2;
            int numberB = 100;

            Console.WriteLine($"數值: {numberA} ~ {numberB}");
            for (int number = numberA; number <= numberB; number++)
            {
                string prime = Convert.ToString(number);
                
                for (int k = 2; k <= (int)Math.Sqrt(number); k++)
                {                    
                    if (number % k == 0)
                    {
                        prime = null;                       
                        break;
                    }                    
                }
                Console.WriteLine(prime);
            }
        }
    }
}
