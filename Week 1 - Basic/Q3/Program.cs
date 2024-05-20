// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input divident:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2;
Console.WriteLine("Input divisor:");
do
{
    num_2 = Convert.ToInt32(Console.ReadLine());
    if (num_2 == 0) Console.WriteLine("Divisor can not be zero! Input again:");
} while (num_2 == 0);
Console.WriteLine("Result:");
Console.WriteLine(num_1 / num_2);
