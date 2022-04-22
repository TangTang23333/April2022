using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Class.Interfaces
{
    internal interface IInstructorService : IPersonService
    {
        public decimal GetSalary(decimal bonus, Class.Instructor person)
        {

            int experience = DateTime.Now.Year - Convert.ToDateTime(person.JoinDate).Year;

            return person.HourSalary * person.Hours + experience * bonus;
                
        }
    }

}
