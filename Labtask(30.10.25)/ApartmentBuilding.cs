using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Labtask_30._10._25_
{
    internal class ApartmentBuilding:Bulding,IRentable
    {
        public int ApartmentCount { get; set; }
        public decimal fee { get; set; }

        public ApartmentBuilding(string name,int apartmentnumber,decimal fee):base(name)
        {
            ApartmentCount = apartmentnumber;
            this.fee = fee;
        }
        public override decimal CalculateMonthlyFee()
        {
            return ApartmentCount * fee; 
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Buildingtype : Apartment");
            Console.WriteLine($"Apartments: {ApartmentCount}");
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
