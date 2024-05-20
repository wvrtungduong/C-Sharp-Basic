// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class Program
    {
        //Create dynamic arrays for storing Employees and Customers
        static List<Employee> employees = new List<Employee>();
        static List<Customer> customers = new List<Customer>();
        static void Main(string[] args)
        {
            //Add some people
            employees.Add(new Employee("ASD", "HERE", 1000));
            employees.Add(new Employee("WHY", "VN", 900));
            employees.Add(new Employee("Helena", "New York", 1200));
            employees.Add(new Employee("John", "House", 950));
            customers.Add(new Customer("Syroup", "HAIPHONG", 400));
            customers.Add(new Customer("mid24", "Ha Noi", 5000));
            customers.Add(new Customer("Clara", "AE", 1000));
            customers.Add(new Customer("WALLNUT", "Backyard", 0));

            int option = 0;
            
            //Loop until user choose exit option
            do
            {   
                //Print menu to console
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Add Customer");
                Console.WriteLine("3. Display Employee with Highest Salary");
                Console.WriteLine("4. Display Customer with Lowest Balance");
                Console.WriteLine("5. Find Employee by Name");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");
                option = getInt32();

                switch (option)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        AddCustomer();
                        break;
                    case 3:
                        DisplayHighestSalaryEmployee();
                        break;
                    case 4:
                        DisplayLowestBalanceCustomer();
                        break;
                    case 5:
                        FindEmployeeByName();
                        break;
                    default:
                        Console.WriteLine("Please input from 0 - 5!");
                        break;
                }
                Console.WriteLine();
            } while (option != 0);

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

        static void AddEmployee()
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Console.Write("Enter employee address: ");
            string address = Console.ReadLine();
            Console.Write("Enter employee salary: ");
            int salary = getInt32();
            employees.Add(new Employee(name, address, salary));
        }

        static void AddCustomer()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter customer address: ");
            string address = Console.ReadLine();
            Console.Write("Enter customer balance: ");
            int salary = getInt32();
            employees.Add(new Employee(name, address, salary));
        }

        static void DisplayHighestSalaryEmployee()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees available.");
                return;
            }

            Employee highestSalaryEmployee = employees[0];

            foreach (var employee in employees)
            {
                if (employee.salary > highestSalaryEmployee.salary)
                {
                    highestSalaryEmployee = employee;
                }
            }

            Console.WriteLine("Employee with the highest salary:");
            highestSalaryEmployee.display();
        }

        static void DisplayLowestBalanceCustomer()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers available.");
                return;
            }

            Customer lowestBalanceCustomer = customers[0];

            foreach (var customer in customers)
            {
                if (customer.balance < lowestBalanceCustomer.balance)
                {
                    lowestBalanceCustomer = customer;
                }
            }

            Console.WriteLine("Customer with the lowest balance:");
            lowestBalanceCustomer.display();
        }

        static void FindEmployeeByName()
        {
            Console.Write("Enter employee name to search: ");
            string name = Console.ReadLine();

            var foundEmployees = employees.FindAll(e => e.getName().Contains(name));

            if (foundEmployees.Count == 0)
            {
                Console.WriteLine("No employees found with that name.");
            }
            else
            {
                Console.WriteLine("Found employees:");
                foreach (var employee in foundEmployees)
                {
                    employee.display();
                }
            }
        }
    }
}