// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a digit: ");
int digit = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 3; i++)
{
    Console.Write(digit);
}
Console.WriteLine();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(digit + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < 3; i++)
{
    Console.Write(digit);
}
Console.WriteLine();
