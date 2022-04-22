using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Class.Class
{
    internal class Person
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
    }

    internal class Student: Person
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

    }

    internal class Instructor : Person
    {
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
    }
}
