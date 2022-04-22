using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Class.Interfaces
{
    internal interface IStudentService
    {
        public double GetGPA(Class.Student student)
        {
            //A=4, B=3, C=2, D=1 and F=0
            double total = 0;
            foreach (KeyValuePair<int, char> entry in student.Grades)
            {
                if (entry.Value == 'A')
                {
                    total += 4;
                } else if (entry.Value == 'B')
                {
                    total += 3;
                } else if (entry.Value == 'C')
                {
                    total += 2;
                } else if (entry.Value == 'D')
                {
                    total += 1;
                }
                
            }

            return total/student.Grades.Count;
        }


    }
}
