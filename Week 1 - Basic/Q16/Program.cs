using System;
using System.Collections.Generic;

public class Q16
{
    static void Main(string[] args)
    {
        Console.WriteLine(modifyString("w3resource"));
        Console.WriteLine(modifyString("Python"));
    }
    public static string modifyString(string str)
    {
        return str.Substring(str.Length-1, 1) + str.Substring(1, str.Length-2) + str.Substring(0, 1);
    }
}
