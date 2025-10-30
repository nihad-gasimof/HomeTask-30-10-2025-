using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask_30._10._25_
{
    public static class DecimalExtensionsMethod 
    {
        public static void ToCurrencyText(this decimal d) 
        {
            Console.WriteLine($"Qiymet: {d} AZN");
        }
    }
}
