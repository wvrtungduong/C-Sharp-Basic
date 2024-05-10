// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Result of specified numbers {0}, {1}, {2}, (x+y).z is {3} and x.y + y.z is {4}", num_1, num_2, num_3, (num_1 + num_2) * num_3, num_1 * num_2 + num_2 * num_3);