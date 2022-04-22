using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Class.Class
{
    internal class Course
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
    }
}
