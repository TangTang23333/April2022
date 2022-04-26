using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Class.Interfaces
{
    internal interface IDepartmentService
    {
        public string GetHead(List<Class.Instructor> instructors);
       


        public double GetBudget(Class.Department dpt);

        public List<string> GetAllCourses(List<Class.Course> courses);
       
    }


    
}
