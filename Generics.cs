using System;
class HelloWorld
{
    static void Main()
    {
        var gens = new Generics<object>();
        int i;
        while (true)
        {
            Console.WriteLine(
@"Обобщение:
 1. Добавление данных в массив
 2. Удаление из массива
 3. Получение элемента из массива по индексу"
);
            var num = Console.ReadLine();
            switch (num)
            {
                case "1":
                    gens.Print("Old ");
                    Console.WriteLine(@"
Тип добавляемых данных:
1. DateTime
2. Boolean
3. Double
4. String
");
                    var t = Console.ReadLine();
                    Console.Write("Введите данные: ");
                    if (t == "1")
                        gens.Add(Convert.ToDateTime(Console.ReadLine()));

                    else if (t == "2")
                        gens.Add(Convert.ToBoolean(Console.ReadLine()));

                    else if (t == "3")
                        gens.Add(Convert.ToDouble(Console.ReadLine()));

                    else
                        gens.Add(Console.ReadLine());
                            
                    gens.Print("New ");
                    break;

                case "2":
                    gens.Print("Old ");
                    Console.Write("Введите индекс для удаления элемента из массива: ");
                    i = int.Parse(Console.ReadLine());
                    gens.Remove(i);
                    gens.Print("New ");
                    break;

                case "3":
                    gens.Print("");
                    Console.Write("Введите индекс для получения элемента из массива: ");
                    i = int.Parse(Console.ReadLine());
                    gens.Find(i);
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
        Console.WriteLine($"Полученный элемент: {generics[i]}");
    }
    public void Print(string age)
    {
        Console.WriteLine($"\n{age}List: {string.Join(", ", generics)}");
    }
}