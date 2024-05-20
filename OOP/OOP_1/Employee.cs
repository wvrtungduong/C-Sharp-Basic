using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal abstract class Employee : IEmployee
    {
        private string name;
        private int paymentPerHour;

        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public abstract int calculateSalary();

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getPaymentPerHour()
        {
            return paymentPerHour;
        }

        public void setPaymentPerHour(int paymentPerHour)
        {
            this.paymentPerHour = paymentPerHour;
        }

        public override string ToString()
        {
            return name + paymentPerHour;
        }
    }
}