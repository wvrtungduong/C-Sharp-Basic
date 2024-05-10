// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input the first number:");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the first number:");
int num_2 = Convert.ToInt32(Console.ReadLine());

int temp = num_1;
num_1 = num_2;
num_2 = temp;
Console.WriteLine("Swapped!");

Console.WriteLine("First number: " + num_1);
Console.WriteLine("Second number: " + num_2);

