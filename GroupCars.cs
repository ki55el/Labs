using System;
using System.Linq;
using System.Xml.Linq;

record class Driver(string fname, string name, Car car);
record class Car(int id, string mark, string color, DateTime realese);
class HelloWorld
{
    static void Main()
    {
        Driver[] drivers =
        {
            new Driver("Ivanov", "Roman", new Car(1234, "GAZ", "blue", Convert.ToDateTime("12.09.2002"))),
            new Driver("Syzdykov", "Damir", new Car(1345, "GAZ", "green", Convert.ToDateTime("15.11.2007"))),
            new Driver("Ivanov", "Maksim", new Car(1456, "Toyota", "blue", Convert.ToDateTime("11.10.2000"))),
            new Driver("Kiselyov", "Mikhail", new Car(1567, "BMW", "yellow", Convert.ToDateTime("10.12.2010")))
        };
        while (true)
        {
            Console.WriteLine(@"
Запросы:
1. Владельцы по машине
2. Машины по марке
3. Владельцы по фамилии
");
            var num = Console.ReadLine();
            switch(num)
            {
                case "1":
                    var by_car = from driver in drivers
                        group driver.fname by driver.car.id;
                    foreach (var car in by_car)
                    {
                        Console.WriteLine(car.Key);
                        foreach (var res in car)
                        {
                            Console.WriteLine('\t' + res);
                        }
                    }
                    break;

                case "2":
                    var by_mark = from driver in drivers
                        group driver.car.color by driver.car.mark;
                    foreach (var mark in by_mark)
                    {
                        Console.WriteLine(mark.Key);
                        foreach (var res in mark)
                        {
                            Console.WriteLine('\t' + res);
                        }
                    }
                    break;

                case "3":
                    var by_fullname = from driver in drivers
                        group driver.name by driver.fname ;
                    foreach (var fname in by_fullname)
                    {
                        Console.WriteLine(fname.Key);
                        foreach (var res in fname)
                        {
                            Console.WriteLine('\t' + res);
                        }
                    }
                    break;
            }
        }
    }
}