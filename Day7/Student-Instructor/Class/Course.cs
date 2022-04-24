using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day7.Class.Interfaces;


namespace Day7.Class.Class
{
    internal class Course : ICourseService
    {
        public int ID;
        public string Name;
        public int InstructorID, DepartmentID;
        public Course(int id, string name, int instuctid, int dptid)
        {
            Name = name;
            ID = id;
            InstructorID = instuctid;
            DepartmentID = dptid;
        }

        public List<int> GetAllStudents(List<Class.Student> students)
        {

            List<int> res = new List<int>();

            foreach (Class.Student student  in students )
            
            {
                if (student.Courses.Contains(ID))
                {
                    res.Add(student.ID);

                }
            }

            return res;
        }

    }
}
