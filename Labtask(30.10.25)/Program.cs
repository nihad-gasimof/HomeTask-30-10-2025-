using Labtask_30._10._25_;

ApartmentBuilding apartment=new ApartmentBuilding("Nihad",30,400);
apartment.ShowInfo();
apartment.GetRent();
apartment.GetContractInfo();

Console.WriteLine(Registry.TotalBuldings);
OfficeBuilding office = new OfficeBuilding("Rashad", 20, 300);
office.ShowInfo();
office.GetRent();
office.GetContractInfo();
Console.WriteLine(Registry.TotalBuldings);
Property nihad = new(1,"nerimanov",300,60,true);
Console.WriteLine($"{nihad.Area},{nihad.Address}");
apartment.fee.ToCurrencyText();
