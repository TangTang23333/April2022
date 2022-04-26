using Day7.Class.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Class.Class
{
    internal class Department : IDepartmentService
    {
        public int ID;
        public string StartTime, EndTime;
        public double Budget;
        

        public Department(
            int id, string start, string end, double budget)
        {
            ID = id;
            StartTime = start;
            EndTime = end;
            Budget = budget;
           

        }

        public List<string> GetAllCourses(List<Course> courses)
        {
            List<string> res = new List<string>();

            foreach (Class.Course c in courses)
            {
                if (c.DepartmentID == ID)
                {
                    res.Add(c.Name);
                }


            }

            return res;
        }

        public double GetBudget(Department dpt)
        {
            return dpt.Budget;
        }

       
        public string GetHead(List<Instructor> instructors)
        {


            foreach (Class.Instructor instructor in instructors)
            {

                if (instructor.DepartmentID != ID)
                {
                    continue;
                }
                if (instructor.ReportsTo == instructor.ID)
                {
                    
                    return instructor.Name;
                }
            }

            return "";

        }





    }
}
