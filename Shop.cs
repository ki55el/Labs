using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

record class Product(string name, int count);
record class Delivery(string date, List<Product> products);
record class Provider(int id, List<Delivery> deliveries);
class HelloWorld
{
    static void Main()
    {
        Provider[] providers = { 
            new Provider(1437, new List<Delivery>
            {
                new Delivery("31.05.23", new List<Product>
                {
                    new Product("Гречка", 55),
                    new Product("Кабачки", 7)
                }),
                new Delivery("30.05.23", new List<Product> {
                    new Product("Квас", 17),
                    new Product("Кефир", 11) 
                })
            }),
            new Provider(1388, new List<Delivery>
            {
                new Delivery("30.05.23", new List<Product>
                {
                    new Product("Гречка", 88),
                    new Product("Вода", 4)
                }),
                new Delivery("28.05.23", new List<Product>
                {
                    new Product("Соль", 44),
                    new Product("Кабачки", 8)
                })
            })
        };
        while (true)
        {
            Console.WriteLine(@"
Группировка по:
1. Поставщикам
2. Товарам
3. Датам
");
            var num = Console.ReadLine();
            switch (num)
            {
                case "1":

                    var provide = from provider in providers
                                  from delivery in provider.deliveries
                                  from prod in delivery.products
                                  group prod.name by provider.id;
                    foreach (var group in provide)
                    {
                        Console.WriteLine(group.Key.ToString() + ':');
                        foreach (var element in group)
                        {
                            Console.WriteLine('\t' + element.ToString());
                        }
                    }
                    break;

                case "2":
                    var product = from provider in providers
                                  from delivery in provider.deliveries
                                  from prod in delivery.products
                                  group provider.id by prod.name;
                    foreach (var group in product)
                    {
                        Console.WriteLine(group.Key.ToString() + ':');
                        foreach (var element in group)
                        {
                            Console.WriteLine('\t' + element.ToString());
                        }
                    }
                    break;

                case "3":
                    var date = from provider in providers
                               from delivery in provider.deliveries
                               from prod in delivery.products
                               group prod.name by delivery.date;
                    foreach (var group in date)
                    {
                        Console.WriteLine(group.Key.ToString() + ':');
                        foreach (var element in group)
                        {
                            Console.WriteLine('\t' + element.ToString());
                        }
                    }
                    break;
            }
            Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
            Console.Clear();
        }
    }
}