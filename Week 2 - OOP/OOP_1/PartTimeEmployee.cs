using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class PartTimeEmployee : Employee
    {
        private int workingHours;

        public PartTimeEmployee(string name, int paymentPerHour, int workingHours) : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }

        public override int calculateSalary()
        {
            return workingHours * getPaymentPerHour();
        }

        public override string ToString()
        {
            return String.Format("|{0}|Part time Employee|{1,13}|{2,16}|", getName().PadRight(32), this.workingHours, getPaymentPerHour());
        }
    }
}