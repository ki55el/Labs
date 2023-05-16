using System;
using System.Linq;
class HelloWorld
{
    static void Main()
    {
        var nums = Console.ReadLine().Split().Select(n => int.Parse(n)).ToList();
        Counter(nums);

        Console.WriteLine("Удаление элементов . . . ");

        nums.RemoveAll(n => n < 0);
        Counter(nums);
    }
    static void Counter(List<int> nums) => Console.WriteLine($@"
min: {nums.Min()}
max: {nums.Max()}
кол-во четных: {nums.Count(n => n % 2 == 0)}
кол-во положительных: {nums.Count(n => n > 0)}
кол-во ненулевых: {nums.Count(n => n != 0)}
");
}
