using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Class.Interfaces
{
    internal interface ICourseService
    {
        public List<int> GetAllStudents(List<Class.Student> students, Class.Course course)
        {

            List<int> res = new List<int>();

            foreach (Class.Student student  in students )
            
            {
                if (student.Courses.Contains(course.ID))
                {
                    res.Add(student.ID);

                }
            }

            return res;
        }
        
    }
}
