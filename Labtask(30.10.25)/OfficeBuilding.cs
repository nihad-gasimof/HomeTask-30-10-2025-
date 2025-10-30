using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask_30._10._25_
{
    internal class OfficeBuilding:Bulding,IRentable
    {
        public int OfficeCount { get; set; }
        public decimal fee { get; set; }

        public OfficeBuilding(string name, int apartmentnumber, decimal fee) : base(name)
        {
            OfficeCount = apartmentnumber;
            this.fee = fee;
        }
        public override decimal CalculateMonthlyFee()
        {
            return OfficeCount * fee;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Buildingtype : Office");
            Console.WriteLine($"Apartments: {OfficeCount}");
            Console.WriteLine($"Fee: {CalculateMonthlyFee()} AZN");

        }
        
        public decimal GetRent()
        {
            return fee;
        }
        public string GetContractInfo()
        {
            return $"Name:{Name}, MounthlyRentFee {GetRent()} Azn";
        }
    }
}
