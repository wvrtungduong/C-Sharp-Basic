using System;

namespace OOP_1
{
    class Program
    {
        //Create a dynamic array to store employees 
        static List<Employee> employees = new List<Employee>();
        static void Main(String[] args)
        {
            //Add some employees
            employees.Add(new FullTimeEmployee("MrPokke", 200));
            employees.Add(new FullTimeEmployee("Lens", 150));
            employees.Add(new FullTimeEmployee("Jin", 210));
            employees.Add(new FullTimeEmployee("Burny", 130));
            employees.Add(new PartTimeEmployee("I genuinely can't believe this",120, 3));
            employees.Add(new PartTimeEmployee("PEASHOOTER", 100, 2));
            employees.Add(new PartTimeEmployee("T1FAKER", 90, 3));
            employees.Add(new PartTimeEmployee("saotoilaioday", 100, 4));

            //Print menu to console
            int option = 0;
            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1. Add new employee");
                Console.WriteLine("2. Display employee list");
                Console.WriteLine("3. Find employee with highest salary");
                Console.WriteLine("4. Find employee by name");
                Console.WriteLine("0. Exit");
                Console.Write("Your choice: ");
                option = getInt32();
                switch (option)
                {
                    case 1:
                        addEmployee();
                        break;
                    case 2:                        
                        //Print all full time employees followed by all part time employees.
                        foreach (var item in employees.OfType<FullTimeEmployee>())
                        {
                                Console.WriteLine(item.ToString());
                        }
                        foreach (var item in employees.OfType<PartTimeEmployee>())
                        {
                                Console.WriteLine(item.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine((FullTimeEmployee)employees.Where(e => e is FullTimeEmployee).OrderByDescending(e => e.calculateSalary()).First());
                        Console.WriteLine((PartTimeEmployee)employees.Where(e => e is PartTimeEmployee).OrderByDescending(e => e.calculateSalary()).First());
                        break;
                    case 4:
                        FindEmployeeByName();
                        break;
                    default:
                        Console.WriteLine("Please input from 0 - 4!");
                        break;
                }
                Console.WriteLine();
            } while (option != 0);
        }

        static void FindEmployeeByName()
        {
            Console.Write("Enter employee name to search: ");
            string name = Console.ReadLine();

            var foundEmployees = employees.FindAll(e => e.getName().Contains(name));

            if (foundEmployees.Count == 0)
            {
                Console.WriteLine("No employee found.");
            }
            else
            {
                Console.WriteLine("Found employees:");
                foreach (var employee in foundEmployees)
                {
                    Console.WriteLine(employee);
                }
            }
        }
        static void addEmployee()
        {
            Console.WriteLine("Fulltime(1) or Parttime(0)");
            int option = getInt32();
            while (true) //Try-catch method to get Employee information
            {
                try
                {
                    Console.Write("Enter employee name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter payment per hour: ");
                    int paymentPerHour = int.Parse(Console.ReadLine());

                    if (option == 0)
                    {
                        Console.Write("Enter working hours: ");
                        int workingHours = int.Parse(Console.ReadLine());

                        employees.Add(new PartTimeEmployee(name, workingHours, paymentPerHour));
                        return;
                    }
                    else
                    {
                        employees.Add(new FullTimeEmployee(name, paymentPerHour));
                        return;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input format, try again:");
                }
            }
        }

        static int getInt32() //Try-catch method to get integer input
        {
            while (true)
            {
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    return input;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input format, try again:");
                }
            }
        }
    }
}