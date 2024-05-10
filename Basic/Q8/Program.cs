// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Output:");
for (int i = 0; i < 11; i++)
{
    Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
}

