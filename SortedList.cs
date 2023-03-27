﻿using System;
using System.Collections;
using System.Collections.Generic;

class HelloWorld {
    static void Main() {
        bool Menu = true;
        do {
            Console.WriteLine(@"SortedList
    1. Add
    2. Clear
    3. ContainsKey
    4. ContainsValue
    5. CopyTo
    6. Remove
    7. RemoveAt
    8. Capacity
    9. GetType
    10. Equals
    11. Comparer
    0. EXIT
                ");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            SortedList<string, string> SList = new SortedList<string, string>() {
                {"www", "0" }, {"$", "#" }, {"&", "3.14" }, {"*", "@" },
                {"1", "^" }, {"abc", "2.7" }, {"%", "Aa" }, {"", "-" }
            };

            switch (number) {

                case 1:     //Add
                    Print("Old ", SList);
                    Console.Write("key=");
                    string add = Console.ReadLine();
                    Console.Write("value=");
                    SList.Add(add, Console.ReadLine());
                    Print("New ", SList);
                    Ok();
                    break;

                case 2:     //Clear
                    Print("Old ", SList);
                    SList.Clear();
                    Print("New ", SList);
                    Ok();
                    break;

                case 3:     //ContainsKey
                    Print("", SList);
                    Console.WriteLine(SList.ContainsKey(Console.ReadLine()));
                    Ok();
                    break;

                case 4:     //ContainsValue
                    Print("", SList);
                    Console.WriteLine(SList.ContainsValue(Console.ReadLine()));
                    Ok();
                    break;

                case 5:     //CopyTo
                    Print("Old ", SList);
                    Array copy = new string[SList.Count];
                    Console.Write("Keys or Values (k/v): ");
                    string kov = Console.ReadLine();
                    if (kov == "k") SList.Keys.CopyTo((string[])copy, 0);
                    else SList.Values.CopyTo((string[])copy, 0);
                    print("New ", copy);
                    Ok();
                    break;

                case 6:     //Remove
                    Print("Old ", SList);
                    SList.Remove(Console.ReadLine());
                    Print("New ", SList);
                    Ok();
                    break;

                case 7:     //RemoveAt
                    Print("Old ", SList);
                    SList.RemoveAt(int.Parse(Console.ReadLine()));
                    Print("New ", SList);
                    Ok();
                    break;

                case 8:     //Capacity
                    Print("", SList);
                    Console.WriteLine($"Capacity: {SList.Capacity}");
                    Ok();
                    break;

                case 9:     //GetType
                    Print("", SList);
                    Console.WriteLine(SList.GetType); 
                    Ok();
                    break;

                case 10:     //Equals
                    Print("1 ", SList);
                    SortedList<string, string> equ = new SortedList<string, string>() {
                        {"www", "0" }, {"$", "#" }, {"&", "3.14" }, {"*", "@" },
                        {"1", "^" }, {"abc", "2.7" }
                    };
                    Print("2 ", equ);
                    Console.WriteLine(SList.Equals(equ));
                    Ok();
                    break;

                case 11:     //Keys
                    Print("", SList);
                    cprint("Keys", SList.Keys);
                    Ok();
                    break;

                case 12:     //Values
                    Print("", SList);
                    cprint("Values", SList.Values);
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
    static void Print(string Age, SortedList<string, string> Inp) {
        Console.WriteLine($"{Age}SortedList: ");
        foreach (KeyValuePair<string,string> e in Inp) {
            Console.WriteLine($"{e.Key}={e.Value} ");
        }
        Console.WriteLine();
    }
    static void print(string Age, Array Inp) {
        Console.WriteLine($"{Age}Array: \n{String.Join(", ", Inp)}");
    }
    static void cprint(string W, IList<string> Inp) {
        Console.WriteLine($"{W}: \n{String.Join(", ", Inp)}");
    }
}