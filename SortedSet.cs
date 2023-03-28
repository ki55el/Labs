﻿using System;
using System.Collections;
using System.Collections.Generic;

class HelloWorld {
    static void Main() {
        bool Menu = true;
        do {
            Console.WriteLine(@"SortedSet
    1. Add
    2. Clear
    3. Contains
    4. CopyTo
    5. SymmetricExceptWith
    6. Remove
    7. IntersectWith
    8. Count
    9. GetType
    10. Equals
    11. IsSubsetOf
    12. UnionWith
    13. Overlaps
    14. Reverse
    0. EXIT
                ");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            SortedSet<string> SSet = new SortedSet<string>() {
                "www", "0" , "$", "#" , "&", "3.14" , "*", "@" ,
                "1", "^" , "abc", "2.7" , "%", "Aa" , "", "-" 
            };

            switch (number) {

                case 1:     //Add
                    Print("Old ", SSet);
                    SSet.Add(Console.ReadLine());
                    Print("New ", SSet);
                    Ok();
                    break;

                case 2:     //Clear
                    Print("Old ", SSet);
                    SSet.Clear();
                    Print("New ", SSet);
                    Ok();
                    break;

                case 3:     //Contains
                    Print("", SSet);
                    Console.WriteLine(SSet.Contains(Console.ReadLine()));
                    Ok();
                    break;

                case 4:     //CopyTo
                    Print("Old ", SSet);
                    Array copy = new string[SSet.Count];
                    SSet.CopyTo((string[])copy);
                    print("New ", copy);
                    Ok();
                    break;

                case 5:     //SymmetricExceptWith
                    Print("Old ", SSet);
                    SortedSet<string> symmmetric = new SortedSet<string>() { "www", "0" , "$", "#" , "&", "3.14" , "*", "@" };
                    Print("Symmetric ", symmmetric);
                    SSet.SymmetricExceptWith(symmmetric);
                    Print("New ", SSet);
                    Ok();
                    break;

                case 6:     //Remove
                    Print("Old ", SSet);
                    SSet.Remove(Console.ReadLine());
                    Print("New ", SSet);
                    Ok();   
                    break;

                case 7:     //IntersectWith
                    Print("Old ", SSet);
                    SortedSet<string> inters = new SortedSet<string>() {
                        "www", "0" , "$", "#" , "&", "*", "@" , "^" , "abc", "%"
                    };
                    Print("IntersectWith ", inters);
                    SSet.IntersectWith(inters);
                    Print("New ", SSet);
                    Ok();
                    break;

                case 8:     //Count
                    Print("", SSet);
                    Console.WriteLine(SSet.Count);
                    Ok();
                    break;

                case 9:     //GetType
                    Print("", SSet);
                    Console.WriteLine(SSet.GetType()); 
                    Ok();
                    break;

                case 10:     //Equals
                    Print("1 ", SSet);
                    SortedSet<string> equ = new SortedSet<string>() {
                        "www", "0" , "$", "#" , "&", "3.14" , "*", "@" ,
                        "1", "^" , "abc", "2.7" , "%", "Aa"
                    };
                    Print("2 ", equ);
                    Console.WriteLine(SSet.Equals(equ));
                    Ok();
                    break;

                case 11:     //IsSubsetOf
                    Print("A.", SSet);
                    SortedSet<string> subs = new SortedSet<string>() {
                        "www", "0" , "$", "#" , "&", "3.14" , "*", "@" ,
                        "1", "^" , "abc", "2.7" , "%", "Aa" , "", "-", "Ё"
                    };
                    Print("B.", subs);
                    Console.WriteLine(SSet.IsSubsetOf(subs));
                    Ok();
                    break;

                case 12:     //UnionWith
                    Print("Old ", SSet);
                    SortedSet<string> uni = new SortedSet<string>() {
                        "www", "0" , "$", "#" , "&", "3.14" , "*", "@" ,
                        "1", "^" , "abc", "2.7" , "%", "Aa" , "", "-", "Ё"
                    };
                    Print("Uni", uni);
                    SSet.UnionWith(uni);
                    Print("New", SSet);
                    Ok();
                    break;

                case 13:    //Overlaps
                    Print("", SSet);
                    SortedSet<string> overl = new SortedSet<string>() { "www" };
                    Print("Overlaps ", overl);
                    Console.WriteLine(SSet.Overlaps(overl));
                    Ok();
                    break;

                case 14:    //Reverse
                    Print("Old ", SSet);
                    var rev = SSet.Reverse();
                    Console.WriteLine($"Reverse SortedSet: \n{String.Join(", ", rev)}");
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
    static void Print(string Age, SortedSet<string> Inp) {
        Console.WriteLine($"{Age}SortedSet: \n{String.Join(", ", Inp)}");
    }
    static void print(string Age, Array Inp) {
        Console.WriteLine($"{Age}Array: \n{String.Join(", ", Inp)}");
    }
}