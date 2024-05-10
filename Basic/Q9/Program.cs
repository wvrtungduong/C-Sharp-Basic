using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int questionNumber = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            program.callMethod(questionNumber);

        }

         void callMethod(int questionNumber)
        {
            var mi = this.GetType().GetMethod("Method" + questionNumber, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            mi.Invoke(this, null);
        }
        static void Q9()
        {
            Console.WriteLine("Hello");
        }
    }
}