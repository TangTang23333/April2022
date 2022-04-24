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
        public int ID, HeadId;
        public string StartTime, EndTime;
        public double Budget;
        

        public Department(
            int id, int head, string start, string end, double budget)
        {
            ID = id;
            HeadId = head;
            StartTime = start;
            EndTime = end;
            Budget = budget;
           

        }

        public List<int> GetAllCourses(List<Course> courses, Department dpt)
        {
            List<int> res = new List<int>();

            foreach (Class.Course c in courses)
            {
                if (c.DepartmentID == dpt.ID)
                {
                    res.Add(c.ID);
                }


            }

            return res;
        }

        public double GetBudget(Department dpt)
        {
            return dpt.Budget;
        }

        string IDepartmentService.GetHead(List<Instructor> instructors, Department dpt)
        {


            foreach (Class.Instructor instructor in instructors)
            {

                if (instructor.DepartmentID != dpt.ID)
                {
                    continue;
                }
                if (instructor.ReportsTo == instructor.ID)
                {
                    dpt.HeadId = instructor.ID;
                    return instructor.Name;
                }
            }

            return "";

        }





    }
}
