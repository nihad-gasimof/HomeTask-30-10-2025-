using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask_30._10._25_
{
    internal static class Registry
    {
        private static int _totalBuldings;
        public static int TotalBuldings { get=>_totalBuldings; }

         static Registry()
        {
            Console.WriteLine("Registry constructoru yaradildi");
        }
        public static void Register(Bulding b)
        {
            _totalBuldings++;
            Console.WriteLine("Yeni Bina elave edildi");
            Console.WriteLine($"TotalBuilding => {TotalBuldings}");
        }
    }
}
