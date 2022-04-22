using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Class.Class
{
    internal class Department
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



    }
}
