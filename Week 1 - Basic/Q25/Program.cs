// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

String str = "Write a C# Sharp Program to display the following pattern using the alphabet.";
String[] words = str.Split(new[] {" "}, StringSplitOptions.None);
int counter = 0;
for (int i = 0; i < words.Length; i++)
{
    if (words[i].Length > counter) counter = words[i].Length;
}
Console.WriteLine(counter);
