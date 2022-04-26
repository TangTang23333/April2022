using Day7.Class.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Class.Class
{
    internal class Person : IPersonService
    {
        public int ID;
        public string DOB, JoinDate, Name, Gender;
        public decimal Hours;
        public decimal HourSalary;
        public List<string> Address;



        public Person(
            int id, 
            string dob, 
            string joinDate,
            string name,
            string gender,
            decimal hoursalary,
            decimal hours,
            List<string> address)
        {
            DOB = dob;
            JoinDate = joinDate;
            Name = name;
            Gender = gender;
            HourSalary = hoursalary;
            Address = address;
            ID = id;
            Hours = hours;

            if (HourSalary < 0)
                throw new ArgumentOutOfRangeException("Only positive values are allowed for HourSalary");
        }




        public int GetAge()
        {
            var today = DateTime.Today;
            DateTime dob = Convert.ToDateTime(DOB);
            // Calculate the age.
            var age = today.Year - dob.Year;

            if (dob.Date > today.AddYears(-age)) { age--; }

            return age;
        }

        public virtual decimal GetSalary()
        {

            if (HourSalary < 0)
            { throw new ArgumentOutOfRangeException("Only positive values are allowed for HourSalary"); }
            return HourSalary * Hours;
        }

        public List<string> GetAddresses()
        {
            foreach (string s in Address)
                Console.WriteLine(s);

            return Address;
        }
    }

    internal class Student: Person , IStudentService
    {
        public List<int> Courses;
        public Dictionary<int, char> Grades;



        public Student(int id,
          
            string dob,
            string joinDate,
            string name,
            string gender,
            decimal hoursalary,
            decimal hours,
            List<string> address,
            Dictionary<int, char> grades,
            List<int> courses
            )
        : base(id, dob, joinDate, name, gender, hoursalary, hours, address)
        {

            Grades = grades;
            Courses = courses;
        }

        public double GetGPA()
        {
            //A=4, B=3, C=2, D=1 and F=0
            double total = 0;
            foreach (KeyValuePair<int, char> entry in Grades)
            {
                if (entry.Value == 'A')
                {
                    total += 4;
                }
                else if (entry.Value == 'B')
                {
                    total += 3;
                }
                else if (entry.Value == 'C')
                {
                    total += 2;
                }
                else if (entry.Value == 'D')
                {
                    total += 1;
                }

            }

            return total / Grades.Count;
        }

    }

    internal class Instructor : Person, IInstructorService
    {
        public static int bonus = 500;
        public int ReportsTo, DepartmentID;
        public string Title;
        
        public Instructor(int id,
            string dob,
            string joinDate,
            string name,
            string gender,
            decimal hoursalary,
            decimal hours,
            List<string> address,
            int reportsto, 
            int dpid, 
            string title)
        :base(id,dob,joinDate,name,gender,hoursalary,hours,address) 
        {
           
            ReportsTo = reportsto;
            DepartmentID = dpid;
            Title = title;
        }

        public override decimal GetSalary()
        {

            int experience = DateTime.Now.Year - Convert.ToDateTime(JoinDate).Year;

            return HourSalary * Hours + experience * bonus;

        }

    }
}
