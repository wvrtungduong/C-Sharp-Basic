using System;
using System.Collections.Generic;

public class Q17
{
    static void Main(string[] args)
    {
        Console.WriteLine(modifyString("The quick brown fox jumps over the lazy dog."));
    }
    public static string modifyString(string str)
    {
        return str.Substring(0, 1) + str + str.Substring(0, 1);
    }
}
