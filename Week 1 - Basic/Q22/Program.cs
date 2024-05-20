// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input first integer: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 80 && num <= 120 || num >= 180 && num <= 220) Console.WriteLine("True");
else Console.WriteLine("False");