using System;
using System.Linq;
using System.Collections.Generic;

record class Driver(string fname, string name, Car car);
record class Car(string id, string mark, string color, DateTime realese);
class HelloWorld
{
    static void Main()
    {
        Driver[] drivers =
        {
            new Driver("Ivanov", "Roman", new Car("1234", "GAZ", "blue", Convert.ToDateTime("12.09.2002"))),
            new Driver("Syzdykov", "Damir", new Car("1345", "GAZ", "green", Convert.ToDateTime("15.11.2007"))),
            new Driver("Ivanov", "Maksim", new Car("1456", "Toyota", "blue", Convert.ToDateTime("11.10.2000"))),
            new Driver("Kiselyov", "Mikhail", new Car("1567", "BMW", "yellow", Convert.ToDateTime("10.12.2010")))
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
                    Printer(by_car);
                    break;

                case "2":
                    var by_mark = from driver in drivers
                                  group driver.car.color by driver.car.mark;
                    Printer(by_mark);
                    break;

                case "3":
                    var by_fullname = from driver in drivers
                                      group driver.name by driver.fname ;
                    Printer(by_fullname);
                    break;
            }
        }
    }
    static void Printer(IEnumerable<IGrouping<string, string>> groups)
    {
        foreach (var group in groups)
        {
            Console.WriteLine(group.Key + ':');
            foreach (var e in group)
            {
                Console.WriteLine('\t' + e);
            }
        }
    }
}
