using System;
using System.Collections;

class HelloWorld
{
    static void Main()
    {
        var strings = new Generics<string>();
        var ints = new Generics<int>();
        int i;
        while (true)
        {
            Console.WriteLine(
@"Тип данных:
1. string
2. int");
            var type = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(
@"Обобщение:
 1. Добавления данных в массив
 2. Удаление из массива
 3. Получение элемента из массива по индексу"
);
            switch (type)
            {
                case "1":
                    var snum = Console.ReadLine();
                    switch (snum)
                    {
                        case "1":
                            strings.Print();
                            strings.Add(Console.ReadLine());
                            strings.Print();
                            break;

                        case "2":
                            strings.Print();
                            Console.Write("Введите индекс для удаления элемента из массива: ");
                            i = int.Parse(Console.ReadLine());
                            strings.Remove(i);
                            strings.Print();
                            break;

                        case "3":
                            strings.Print();
                            Console.Write("Введите индекс для получения элемента из массива: ");
                            i = int.Parse(Console.ReadLine());
                            strings.Find(i);
                            strings.Print();
                            break;
                    }
                    break;
                case "2":
                    var inum = Console.ReadLine();
                    switch (inum)
                    {
                        case "1":
                            ints.Print();
                            ints.Add(int.Parse(Console.ReadLine()));
                            ints.Print();
                            break;

                        case "2":
                            ints.Print();
                            Console.Write("Введите индекс для удаления элемента из массива: ");
                            i = int.Parse(Console.ReadLine());
                            ints.Remove(i);
                            ints.Print();
                            break;

                        case "3":
                            ints.Print();
                            Console.Write("Введите индекс для получения элемента из массива: ");
                            i = int.Parse(Console.ReadLine());
                            ints.Find(i);
                            ints.Print();
                            break;
                    }
                    break;
        }
            Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
class Generics<T>
{
    List<T> generics;
    public Generics()
    {
        generics = new List<T>();
    }
    public void Add(T item)
    {
        generics.Add(item);
    }
    public void Remove(int i)
    {
        generics.RemoveAt(i);
    }
    public void Find(int i)
    {
        Console.WriteLine(generics[i]);
    }
    public void Print()
    {
        Console.WriteLine($"List:   {string.Join(" ", generics)}");
    }
}
