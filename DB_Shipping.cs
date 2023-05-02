using System;
using System.Xml.Linq;

class HelloWorld
{
    static void Main()
    {
        var t = new Transport("");
        var c = new Chief("", DateTime.Now, DateTime.Now);
        var d = new Driver("", DateTime.Now, DateTime.Now);
        var m = new Mechanic("", DateTime.Now, DateTime.Now);

        var garage = new List<Transport>();
        var drivers = new List<Driver>();
        var mechanics = new List<Mechanic>();
        var chiefs = new List<Chief>();

        bool menu = true;
        do
        {
            Console.WriteLine(
@"Предприятие автотранспорта:
1. История техосмотров
2. Водители
3. Ремонтые работы
4. Стаж и общий стаж работы
5. Приказы
6. Добавление данных
7. Взаимодействие
0. Выход"
            );
            var num = Console.ReadLine();
            Console.Clear();
            switch (num)
            {
                case "1":
                    t.PrintTransport(garage);
                    Console.Write("История техосмотров траспорта №");
                    var i = int.Parse(Console.ReadLine());
                    garage[i].PrintTechInspect();
                    break;

                case "2":
                    t.PrintTransport(garage);
                    Console.Write("Водители траспорта №");
                    i = int.Parse(Console.ReadLine());
                    garage[i].PrintDrivers();
                    break;

                case "3":
                    t.PrintTransport(garage);
                    Console.Write("Ремонтые работы траспорта №");
                    i = int.Parse(Console.ReadLine());
                    garage[i].PrintRepair();
                    break;

                case "4":
                    Console.WriteLine("Опыт работы: ");
                    c.ExpChiefs(chiefs);
                    d.ExpDrivers(drivers);
                    m.ExpMechanics(mechanics);
                    break;

                case "5":
                    c.PrintChiefs(chiefs);
                    Console.Write("Приказы начальника №");
                    i = int.Parse(Console.ReadLine());
                    chiefs[i].PrintOrders();
                    break;

                case "6":
                    Console.WriteLine(
@"Добавить:
1. Автобус
2. Грузовик
3. Водителя
4. Механика
5. Начальника"
                    );
                    num = Console.ReadLine();
                    if (num == "1")
                    {
                        Console.Write("Название автобуса: ");
                        garage.Add(new Bus(Console.ReadLine()));
                    }
                    else if (num == "3")
                    {
                        Console.Write("ФИО водителя: ");
                        var name = Console.ReadLine();
                        Console.Write("Начало работы в компании: ");
                        var start = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Начало работы: ");
                        var total_start = Convert.ToDateTime(Console.ReadLine());
                        drivers.Add(new Driver(name, start, total_start));
                    }
                    else if (num == "4")
                    {
                        Console.Write("ФИО механика: ");
                        var name = Console.ReadLine();
                        Console.Write("Начало работы в компании: ");
                        var start = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Начало работы: ");
                        var total_start = Convert.ToDateTime(Console.ReadLine());
                        mechanics.Add(new Mechanic(name, start, total_start));
                    }
                    else if (num == "5")
                    {
                        Console.Write("ФИО начальника: ");
                        var name = Console.ReadLine();
                        Console.Write("Начало работы в компании: ");
                        var start = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Начало работы: ");
                        var total_start = Convert.ToDateTime(Console.ReadLine());
                        chiefs.Add(new Chief(name, start, total_start));
                    }
                    else
                    {
                        Console.Write("Название грузовика: ");
                        garage.Add(new Truck(Console.ReadLine()));
                    }
                    break;

                case "7":
                    Console.WriteLine(
@"Действия:
1. Провести техосмотр транспорта
2. Предоставить водителю транспорт
3. Отремонтировать транспорт
4. Выдать приказ"
                    );
                    num = Console.ReadLine();
                    if (num == "1")
                    {
                        t.PrintTransport(garage);
                        Console.Write("Техосмотр траспорта №");
                        i = int.Parse(Console.ReadLine());
                        garage[i].TechInspect(DateTime.Now);
                    }
                    else if (num == "2")
                    {
                        t.PrintTransport(garage);
                        Console.Write("Предоставить траспорт №");
                        i = int.Parse(Console.ReadLine());
                        d.PrintDrivers(drivers);
                        Console.Write("водителю №");
                        var j = int.Parse(Console.ReadLine());
                        garage[i].Drive(drivers[j]);
                    }
                    else if (num == "3")
                    {
                        t.PrintTransport(garage);
                        Console.Write("Ремонт траспорта №");
                        i = int.Parse(Console.ReadLine());
                        m.PrintMechanics(mechanics);
                        Console.Write("Ремонтирует механик №");
                        var j = int.Parse(Console.ReadLine());
                        Console.Write("Причина ремонта: ");
                        var rep = Console.ReadLine();
                        garage[i].Repair(mechanics[j], rep);
                    }
                    else
                    {
                        c.PrintChiefs(chiefs);
                        Console.Write("От начальника №");
                        i = int.Parse(Console.ReadLine());
                        Console.Write("Приказ: ");
                        chiefs[i].Order(Console.ReadLine());
                    }
                    break;

                case "0":
                    menu = false;
                    break;

                default:
                    Console.WriteLine("Некорректный ввод");
                    break;
            }
            Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
            Console.Clear();
        } while (menu);
    }
}
class Transport
{
    private string name;
    private List<DateTime> tech_inspect;
    private List<Driver> drivers;
    private List<string> repair;

    public Transport(string name)
    {
        this.name = name;
        this.drivers = new List<Driver>();
        this.tech_inspect = new List<DateTime>();
        this.repair = new List<string>();
    }
    public void PrintDrivers()
    {
        Console.WriteLine($"Водители {name}: \n{String.Join("\n", drivers)}");
    }
    public void PrintRepair()
    {
        Console.WriteLine($"Ремонтые работы {name}: \n{String.Join("\n", repair)}");
    }
    public void PrintTechInspect()
    {
        Console.WriteLine($"Техосмотры {name}: \n{String.Join("\n", tech_inspect)}");
    }
    public void PrintTransport(List<Transport> garage)
    {
        Console.WriteLine("Гараж:");
        for (int i = 0; i < garage.Count; i++)
        {
            Console.WriteLine($"{i}. {garage[i]} {garage[i].name}");
        }
    }
    public void Drive(Driver driver)
    {
        drivers.Add(driver);
    }
    public void Repair(Mechanic mechanic, string rep)
    {
        repair.Add($"{mechanic.fname}: {rep}");
    }
    public void TechInspect(DateTime date)
    {
        tech_inspect.Add(date);
    }
}
class Truck : Transport
{
    public Truck(string name) : base(name) { }
}
class Bus : Transport
{
    public Bus(string name) : base(name) { }
}
class Worker
{
    private string fullname;
    private DateTime startwork;
    private DateTime total_startwork;

    public Worker(string fullname, DateTime startwork, DateTime total_startwork)
    {
        this.fullname = fullname;
        this.startwork = startwork;
        this.total_startwork = total_startwork;
    }
    public string fname(Worker obj)
    {
        return obj.fullname;
    }
    public void Exp(Worker obj)
    {
        int d = (DateTime.Now - obj.startwork).Days;
        int dt = (DateTime.Now - obj.total_startwork).Days;
        var y = d / 365;    var m = d % 365 / 30;
        var yt = dt / 365;  var mt = dt % 365 / 30;
        Console.WriteLine($"{obj.fullname}:  {y} г. {m} м., общий: {yt} г. {mt} м.");
    }
}
class Mechanic : Worker
{
    public Mechanic(string fullname, DateTime startwork, DateTime total_startwork) 
        : base(fullname, startwork, total_startwork) { }
    public void PrintMechanics(List<Mechanic> mechanics)
    {
        Console.WriteLine("Механики:");
        for (int i = 0; i < mechanics.Count; i++)
        {
            Console.WriteLine($"{i}. {mechanics[i].fname}");
        }
    }
    public void ExpMechanics(List<Mechanic> mechanics)
    {
        for (int i = 0; i < mechanics.Count; i++)
            Exp(mechanics[i]);
    }
}
class Chief : Worker
{
    private List<string> orders;
    public Chief(string fullname, DateTime startwork, DateTime total_startwork)
    : base(fullname, startwork, total_startwork)
    {
        this.orders = new List<string>();
    }
    public void PrintChiefs(List<Chief> chiefs)
    {
        Console.WriteLine("Начальники:");
        for (int i = 0; i < chiefs.Count; i++)
        {
            Console.WriteLine($"{i}. {chiefs[i].fname}");
        }
    }
    public void ExpChiefs(List<Chief> chiefs)
    {
        for (int i = 0; i < chiefs.Count; i++)
            Exp(chiefs[i]);
    }
    public void Order(string ord)
    {
        orders.Add(ord);
    }
    public void PrintOrders()
    {
        Console.WriteLine($"Приказы: \n{String.Join("\n", orders)}");
    }
}
class Driver : Worker
{
    public Driver(string fullname, DateTime startwork, DateTime total_startwork)
    : base(fullname, startwork, total_startwork) { }
    public void PrintDrivers(List<Driver> drivers)
    {
        Console.WriteLine("Водители:");
        for (int i = 0; i < drivers.Count; i++)
        {
            Console.WriteLine($"{i}. {drivers[i].fname}");
        }
    }
    public void ExpDrivers(List<Driver> drivers)
    {
        for (int i = 0; i < drivers.Count; i++)
            Exp(drivers[i]);
    }
}