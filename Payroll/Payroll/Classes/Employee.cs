using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Classes
{
    public class Employee: Person
    {
        string jobTitle;
        float wage;
        float hoursWorked;
        bool onPayroll;

        public Employee()
        {

        }

        public Employee(string jobTitle, float wage, float hoursWorked, bool onPayroll)
        {
            this.jobTitle = jobTitle;
            this.wage = wage;
            this.hoursWorked = hoursWorked;
            this.onPayroll = onPayroll;
        }

        public float Pay()
        {
            return 0;
        }
    }
}
