using System;
class Car
{
    public string name;
    public bool clean;
    public Car(string name)
    {
        this.name = name;
        clean = false;
    }
    public void Print()
    {
        Console.WriteLine($"{name}: {clean}");
    }
}
class Garage<Car>
{
    public List<Car> Cars;
    public Garage()
    {
        Cars = new List<Car>();
    }
    public void Add(Car car) => Cars.Add(car);
    public Car For(int i) => Cars[i];
    public int Count() => Cars.Count;
}
class CarWash
{
    public void Wash(Car car) => car.clean = true;
}
class HelloWorld
{
    delegate void Action(Car car);
    static void Main()
    {
        var garage = new Garage<Car>();
        var carwash = new CarWash();
        garage.Add(new Car("Kio"));
        garage.Add(new Car("Toyota"));
        garage.Add(new Car("Honda"));
        Action washing = carwash.Wash;
        for (int i = 0; i < garage.Count(); i++)
            garage.For(i).Print();
        Console.WriteLine("\nПроцесс мытья . . . \n");
        for (int i = 0; i < garage.Count(); i++)
        {
            washing(garage.For(i));
            garage.For(i).Print();
        }
    }
}