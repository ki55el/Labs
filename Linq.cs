using System;
using System.Linq;
class HelloWorld
{
    static void Main()
    {
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Counter(nums);

        Console.WriteLine("Удаление элементов . . . ");

        nums = (from n in nums
               where n > 0
               select n).ToArray();
        Counter(nums);
    }
    static void Counter(int[] nums) => Console.WriteLine($@"
min: {nums.Min()}
max: {nums.Max()}
кол-во четных: {nums.Count(n => n % 2 == 0)}
кол-во положительных: {nums.Count(n => n > 0)}
кол-во ненулевых: {nums.Count(n => n != 0)}
");
}