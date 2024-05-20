// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a digit: ");
int digit = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(digit + " ");
    }
    Console.WriteLine();
    for (int l = 0; l < 4; l++)
    {
        Console.Write(digit);
    }
    Console.WriteLine();
}
