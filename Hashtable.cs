﻿using System;
using System.Collections;
using System.Collections.Generic;

class HelloWorld {
    static void Main() {
        bool Menu = true;
        do {
            Console.WriteLine(@"Hashtable
    1. Add
    2. Clear
    3. ContainsKey
    4. ContainsValue
    5. CopyTo
    6. Remove
    7. Synchronized
    8. Clone
    9. GetType
    10. Equals
    0. EXIT
                ");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Hashtable Hasht = new Hashtable() {
                { 123, "12345678" },
                { "alph", "abcdefgh" },
                { "char", "!@#$%^&*" }
            };

            switch (number) {

                case 1:     //Add
                    Print("Old", Hasht);
                    Console.Write("Key=");
                    string add = Console.ReadLine();
                    Console.Write("value=");
                    Hasht.Add(add, Console.ReadLine());
                    Print("New", Hasht);
                    Ok();
                    break;

                case 2:     //Clear
                    Print("Old", Hasht);
                    Hasht.Clear();
                    Print("New", Hasht);
                    Ok();
                    break;

                case 3:     //ContainsKey
                    Print("", Hasht);
                    Console.WriteLine(Hasht.ContainsKey(Console.ReadLine()));
                    Ok();
                    break;

                case 4:     //ContainsValue
                    Print("", Hasht);

                    Console.WriteLine(Hasht.ContainsValue(Console.ReadLine()));
                    Ok();
                    break;

                case 5:     //CopyTo
                    Print("Old", Hasht);
                    Array copy = new string[Hasht.Count];
                    Console.Write("Keys or Values (k/v): ");
                    string kov = Console.ReadLine();
                    if (kov == "k") Hasht.Keys.CopyTo(copy, 0);
                    else Hasht.Values.CopyTo(copy, 0);
                    print("New", copy);
                    Ok();
                    break;

                case 6:     //Remove
                    Print("Old", Hasht);
                    Hasht.Remove(Console.ReadLine());
                    Print("New", Hasht);
                    Ok();
                    break;

                case 7:     //Synchronized
                    Print("", Hasht);
                    Hashtable Synchr = Hashtable.Synchronized(Hasht);
                    Print("New", Synchr);
                    Ok();
                    break;

                case 8:     //Clone
                    Print("Old", Hasht);
                    Hasht.Clone();
                    Print("New", Hasht);
                    Ok();
                    break;

                case 9:     //GetType
                    Print("", Hasht);
                    Console.WriteLine(Hasht.GetType); 
                    Ok();
                    break;

                case 10:     //Equals
                    Print("1", Hasht);
                    Hashtable Equ = new Hashtable() {
                        { 123, "45678" },
                        { "a", "abc" },
                        { "c", "!@#" }
                    };
                    Print("2", Equ);
                    Console.WriteLine(Hasht.Equals(Equ));

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
    static void Print(string Age, Hashtable Inp) {
        Console.WriteLine($"{Age} Hashtable: ");
        foreach (DictionaryEntry e in Inp) {
            Console.WriteLine($"{e.Key}={e.Value} ");
        }
        Console.WriteLine();
    }
    static void print(string Age, Array Inp) {
        Console.WriteLine($"{Age} Array: ");
        foreach (var e in Inp) {
            Console.Write($"{e} ");
        }
        Console.WriteLine();
    }
}