using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    var stack = new Stack<char>();
    var list = Console.ReadLine();
    var ans = "YES";
    foreach (char e in list) {
        if (e == ')' || e == ']' || e == '}') {
            if (stack.Count == 0) { 
                ans = "NO";
                break;
            }
            var bracket = stack.Pop();
            if ((bracket != '(' && e == ')') || (bracket != '[' && e == ']') || (bracket != '{' && e == '}')) { 
                ans = "NO";
                break;
            }
        }
        else if (e == '(' || e == '[' || e == '{') 
            stack.Push(e);
    }
    if (stack.Count != 0)
        ans = "NO";
    Console.WriteLine(ans);
  }
}
