// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the amount of Celsius: ");
int celsius = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kelvin = {0}", celsius + 273);
Console.WriteLine("Fahrenheit = {0}", celsius * 9 / 5 + 32);
