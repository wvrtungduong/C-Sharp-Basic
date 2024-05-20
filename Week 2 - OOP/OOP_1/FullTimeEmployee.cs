using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {
        }

        public override int calculateSalary()
        {
            return 8 * getPaymentPerHour();
        }

        public override string ToString()
        {
            return String.Format("|{0}|Full time Employee|             |{1,16}|", getName().PadRight(32), getPaymentPerHour());
            //return getName() + ": Full time Employee, payment per hour: " + getPaymentPerHour();
        }
    }
}