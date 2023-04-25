﻿using System;
using System.Collections;
using System.Collections.Generic;

class HelloWorld {
    static void Main() {
        bool Menu = true;
        do {
            Console.WriteLine(@"HashSet
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
    0. EXIT
                ");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            HashSet<string> HSet = new HashSet<string>() {
                "www", "0" , "$", "#" , "&", "3.14" , "*", "@" ,
                "1", "^" , "abc", "2.7" , "%", "Aa" , "", "-" 
            };

            switch (number) {

                case 1:     //Add
                    Print("Old ", HSet);
                    HSet.Add(Console.ReadLine());
                    Print("New ", HSet);
                    Ok();
                    break;

                case 2:     //Clear
                    Print("Old ", HSet);
                    HSet.Clear();
                    Print("New ", HSet);
                    Ok();
                    break;

                case 3:     //Contains
                    Print("", HSet);
                    Console.WriteLine(HSet.Contains(Console.ReadLine()));
                    Ok();
                    break;

                case 4:     //CopyTo
                    Print("Old ", HSet);
                    Array copy = new string[HSet.Count];
                    HSet.CopyTo((string[])copy);
                    print("New ", copy);
                    Ok();
                    break;

                case 5:     //SymmetricExceptWith
                    Print("Old ", HSet);
                    HashSet<string> symmmetric = new HashSet<string>() { "www", "0" , "$", "#" , "&", "3.14" , "*", "@" };
                    Print("Symmetric ", symmmetric);
                    HSet.SymmetricExceptWith(symmmetric);
                    Print("New ", HSet);
                    Ok();
                    break;

                case 6:     //Remove
                    Print("Old ", HSet);
                    HSet.Remove(Console.ReadLine());
                    Print("New ", HSet);
                    Ok();
                    break;

                case 7:     //IntersectWith
                    Print("Old ", HSet);
                    HashSet<string> inters = new HashSet<string>() {
                        "www", "0" , "$", "#" , "&", "*", "@" , "^" , "abc", "%"
                    };
                    Print("IntersectWith ", inters);
                    HSet.IntersectWith(inters);
                    Print("New ", HSet);
                    Ok();
                    break;

                case 8:     //Count
                    Print("", HSet);
                    Console.WriteLine(HSet.Count);
                    Ok();
                    break;

                case 9:     //GetType
                    Print("", HSet);
                    Console.WriteLine(HSet.GetType()); 
                    Ok();
                    break;

                case 10:     //Equals
                    Print("1 ", HSet);
                    HashSet<string> equ = new HashSet<string>() {
                        "www", "0" , "$", "#" , "&", "3.14" , "*", "@" ,
                        "1", "^" , "abc", "2.7" , "%", "Aa"
                    };
                    Print("2 ", equ);
                    Console.WriteLine(HSet.Equals(equ));
                    Ok();
                    break;

                case 11:     //IsSubsetOf
                    Print("A.", HSet);
                    HashSet<string> subs = new HashSet<string>() {
                        "www", "0" , "$", "#" , "&", "3.14" , "*", "@" ,
                        "1", "^" , "abc", "2.7" , "%", "Aa" , "", "-", "Ё"
                    };
                    Print("B.", subs);
                    Console.WriteLine(HSet.IsSubsetOf(subs));
                    Ok();
                    break;

                case 12:     //UnionWith
                    Print("Old ", HSet);
                    HashSet<string> uni = new HashSet<string>() {
                        "www", "0" , "$", "#" , "&", "3.14" , "*", "@" ,
                        "1", "^" , "abc", "2.7" , "%", "Aa" , "", "-", "Ё"
                    };
                    Print("Uni", uni);
                    HSet.UnionWith(uni);
                    Print("New", HSet);
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
    static void Print(string Age, HashSet<string> Inp) {
        Console.WriteLine($"{Age}HashSet: \n{String.Join(", ", Inp)}");
    }
    static void print(string Age, Array Inp) {
        Console.WriteLine($"{Age}Array: \n{String.Join(", ", Inp)}");
    }
}
