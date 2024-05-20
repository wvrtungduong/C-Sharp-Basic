// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input the first number:");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number:");
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Output:");
Console.WriteLine("{0} + {1} = {2}", num_1, num_2, num_1 + num_2);
Console.WriteLine("{0} - {1} = {2}", num_1, num_2, num_1 - num_2);
Console.WriteLine("{0} x {1} = {2}", num_1, num_2, num_1 * num_2);
Console.WriteLine("{0} / {1} = {2}", num_1, num_2, num_1 / num_2);
Console.WriteLine("{0} mod {1} = {2}", num_1, num_2, num_1 % num_2);