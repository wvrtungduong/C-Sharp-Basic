// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input first integer: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer");
int num_2 = Convert.ToInt32(Console.ReadLine());
if  ((num_1 * num_2) < 0)
{
    Console.WriteLine("True");
} 
else
{
    Console.WriteLine("False");
}
