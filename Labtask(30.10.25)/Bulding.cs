using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask_30._10._25_
{
    internal abstract class Bulding
    {
        public int Id { get; init; }
        public string Name { get; set; }
        private static  int _idcounter=0;
        
       public  abstract decimal CalculateMonthlyFee();

        protected Bulding(string Name)
        {
            _idcounter++;
            Id = _idcounter;
            this.Name = Name;
            Registry.Register(this);
            
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"ID:{Id}, Name: {Name}");
        }
    }
}
