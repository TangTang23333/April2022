using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Class.Interfaces
{
    internal interface IPersonService
    {
        public int GetAge(Class.Person person)
        {
            var today = DateTime.Today;
            DateTime dob = Convert.ToDateTime(person.DOB);
            // Calculate the age.
            var age = today.Year - dob.Year;

            if (dob.Date > today.AddYears(-age)) { age--; }

            return age;
        }

        public decimal GetSalary(Class.Person person)
        {
           
            if (person.HourSalary < 0)
                throw new ArgumentOutOfRangeException("Only positive values are allowed for HourSalary");
            return person.HourSalary * person.Hours;
        }

        public List<string> GetAddresses(Class.Person person)
        {
            foreach (string s in person.Address) 
                Console.WriteLine(s);

            return person.Address;
        }


    }
}
