using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Class.Interfaces
{
    internal interface IDepartmentService
    {
        public string GetHead(List<Class.Instructor> instructors, Class.Department dpt)
        {
            foreach (Class.Instructor instructor in instructors)
            {

                if (instructor.DepartmentID != dpt.ID)
                {
                    continue;
                }
                if (instructor.ReportsTo == instructor.ID )
                {
                    dpt.HeadId = instructor.ID;
                    return instructor.Name;
                }
            }

            return "";
        }


        public double GetBudget(Class.Department dpt)
        {
            return dpt.Budget;
        }

        public List<int> GetAllCourses(List<Class.Course> courses, Class.Department dpt)
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
    }


    
}
