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

        public Employee() : base()
        {
            jobTitle = "jobTitile";
            wage = 0;
            hoursWorked = 0;
            onPayroll = false;
        }

        public Employee(string firstname, string lastName, long phoneNumber, Address address , string jobTitle, float wage, float hoursWorked, bool onPayroll) : base(firstname,lastName,phoneNumber,address)
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
        public override string ToString()
        {
            string data = base.ToString()+ "\n"+ "Title: "+ jobTitle + ", Wage: "+ wage +", Hours Worked: "+ hoursWorked+ ", On Payroll: " + onPayroll;
            return data;
        }
    }
}
