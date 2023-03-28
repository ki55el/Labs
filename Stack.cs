using System;
using System.Collections;
using System.Collections.Generic;

class HelloWorld {
    static void Main() {
        bool Menu = true;
        do {
            Console.WriteLine(@"Stack
    1. Clear
    2. Contains
    3. CopyTo
    4. Count
    5. Equals
    6. GetType
    7. Peek
    8. Pop
    9. Push
    10. ToArray
    11. TryPeek
    12. TryPop
    0. EXIT
                ");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            List<string> list = new List<string>() { "www", "0", "$", "#", "&", "3.14", "*", "@", "1", "^", "abc", "2.7", "%", "Aa", "", "-" };
            Stack<string> stack = new Stack<string>(list);
            string res = "";
            switch (number) {

                case 1:     //Clear
                    Print("Old ", stack);
                    stack.Clear();
                    Print("New ", stack);
                    Ok();
                    break;

                case 2:     //Contains
                    Print("", stack);
                    Console.WriteLine(stack.Contains(Console.ReadLine()));
                    Ok();
                    break;

                case 3:     //CopyTo
                    Print("", stack);
                    string[] copy = new string[stack.Count];
                    stack.CopyTo(copy, 0);
                    print("", copy);
                    Ok();
                    break;

                case 4:     //Count
                    Print("", stack);
                    Console.WriteLine(stack.Count);
                    Ok();
                    break;

                case 5:     //Equals
                    Print("1 ", stack);
                    Stack<string> eqs = new Stack<string>(list);
                    Print("2 ", stack);
                    Console.WriteLine(stack.Equals(stack));
                    Ok();
                    break;

                case 6:     //GetType
                    Print("", stack);
                    Console.WriteLine(stack.GetType());
                    Ok();
                    break;

                case 7:     //Peek
                    Print("Old ", stack);
                    Console.WriteLine(stack.Peek());
                    Print("New ", stack);
                    Ok();
                    break;

                case 8:     //Pop
                    Print("Old ", stack);
                    Console.WriteLine(stack.Pop());
                    Print("New ", stack);
                    Ok();
                    break;

                case 9:     //Push
                    Print("Old ", stack);
                    stack.Push(Console.ReadLine());
                    Print("New ", stack);
                    Ok();
                    break;

                case 10:     //ToArray
                    Print("Old ", stack);
                    print("New ", stack.ToArray());
                    Ok();
                    break;

                case 11:     //TryPeek
                    Print("Old ", stack);
                    stack.TryPeek(out res);
                    Console.WriteLine($"Peek: {res}");
                    Print("New ", stack);
                    Ok();
                    break;

                case 12:     //TryPop
                    Print("Old ", stack);
                    stack.TryPop(out res);
                    Console.WriteLine($"Pop: {res}");
                    Print("New ", stack);
                    Ok();
                    break;

                case 0:     //Exit
                    Menu = false;
                    break;

            }
            Console.Clear();
        } while (Menu);
    }
    static void Ok() {
        Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
        Console.ReadKey();
    }
    static void Print(string Age, Stack<string> Inp) {
        Console.WriteLine($"{Age}Stack: \n{String.Join(", ", Inp)}");
    }
    static void print(string Age, string[] Inp) {
        Console.WriteLine($"{Age}Array: \n{String.Join(", ", Inp)}");
    }
}
