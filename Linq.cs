using System;
using System.Linq;
class HelloWorld
{
    static void Main()
    {
        var all = from n in Console.ReadLine().Split()
            select int.Parse(n);
        Printer(all);

        Console.WriteLine("Удаление отрицательных элементов . . . ");

        var nominus = from n in all
            where n >= 0
            select n;
        Printer(nominus);
    }
    static void Printer(IEnumerable<int> nums)
    {
        var even = from n in nums
            where n % 2 == 0
            select n;

        var plus = from n in nums
            where n > 0
            select n;

        var nozero = from n in nums
            where n != 0
            select n;

        Console.WriteLine($@"
min: {nums.Min()}
max: {nums.Max()}
кол-во четных: {even.Count()}
кол-во положительных: {plus.Count()}
кол-во ненулевых: {nozero.Count()}
");
    }
}
