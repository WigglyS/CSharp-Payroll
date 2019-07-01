using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Classes
{
    public class Person
    {
        string firstName;
        string lastName;
        int phoneNumber;

        Address address;

        public Person()
        {

        }

        public Person(string firstName, string lastName, int phoneNumber, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
